using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.BZip2;
using Unzipper.Utils;

namespace Unzipper
{
    public partial class Form1 : Form
    {
        private string selectedArchivePath;
        private readonly IExtractor _extractor;
        private readonly IFileManager _fileManager;

        public Form1(IFileManager fileManager, IExtractor extractor)
        {
            _fileManager = fileManager;
            _extractor = extractor;
            InitializeComponent();
        }
        
        private void buttonPathSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            
            fld.ShowNewFolderButton = true;

            if (fld.ShowDialog() == DialogResult.OK)
            {
                this.selectedArchivePath = fld.SelectedPath;
                toolStripStatusLabelChoosenDir.Text = $"Selected archive: {selectedArchivePath}";
            }
        }

        private async void buttonExtract_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.selectedArchivePath))
            {
                MessageBox.Show("Select path!");
                return;
            }

            bool deletefls = DeleteFiles();

            var files = _fileManager.DirSearch(this.selectedArchivePath).Take(60);

            foreach (var file in files)
            {
                var filepath = await _extractor.ExtractAsync(file, deletefls);
                unarchivedItemsListBox.Items.Add(filepath);
            }
            
            MessageBox.Show($"Done!");
        }

        private void showFileButton_Click(object sender, EventArgs e)
        {
            var selectedPath = unarchivedItemsListBox.SelectedItem?.ToString();
        
            if (string.IsNullOrEmpty(selectedPath))
            {
                MessageBox.Show("Choose any file");
                return;
            }

            _fileManager.OpenFile(selectedPath);
        }

        private bool DeleteFiles()
        {
            DialogResult dialogResult = MessageBox.Show("Delete archive files after uncompressing?",
                "Delete files", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                return true;
            else
                return false;

        }
    }
}
