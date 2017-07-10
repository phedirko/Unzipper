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
        public string selectedArchivePath;

        public Form1()
        {
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

            var files = FileSystemMananger.DirSearch(this.selectedArchivePath);

            foreach (var file in files)
            {
                var filepath = await Utils.Unzipper.ExtractAsync(file);
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

            Utils.FileSystemMananger.OpenFile(selectedPath);
        }
    }
}
