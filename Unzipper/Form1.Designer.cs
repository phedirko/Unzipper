namespace Unzipper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPathSelect = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.unarchivedItemsListBox = new System.Windows.Forms.ListBox();
            this.showFileButton = new System.Windows.Forms.Button();
            this.choosenDirStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelChoosenDir = new System.Windows.Forms.ToolStripStatusLabel();
            this.choosenDirStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPathSelect
            // 
            this.buttonPathSelect.Location = new System.Drawing.Point(12, 256);
            this.buttonPathSelect.Name = "buttonPathSelect";
            this.buttonPathSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonPathSelect.TabIndex = 2;
            this.buttonPathSelect.Text = "Select";
            this.buttonPathSelect.UseVisualStyleBackColor = true;
            this.buttonPathSelect.Click += new System.EventHandler(this.buttonPathSelect_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(93, 256);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(75, 23);
            this.buttonExtract.TabIndex = 3;
            this.buttonExtract.Text = "Extract!";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // unarchivedItemsListBox
            // 
            this.unarchivedItemsListBox.FormattingEnabled = true;
            this.unarchivedItemsListBox.Location = new System.Drawing.Point(12, 12);
            this.unarchivedItemsListBox.Name = "unarchivedItemsListBox";
            this.unarchivedItemsListBox.Size = new System.Drawing.Size(408, 199);
            this.unarchivedItemsListBox.TabIndex = 7;
            // 
            // showFileButton
            // 
            this.showFileButton.Location = new System.Drawing.Point(345, 256);
            this.showFileButton.Name = "showFileButton";
            this.showFileButton.Size = new System.Drawing.Size(75, 23);
            this.showFileButton.TabIndex = 6;
            this.showFileButton.Text = "Show";
            this.showFileButton.UseVisualStyleBackColor = true;
            this.showFileButton.Click += new System.EventHandler(this.showFileButton_Click);
            // 
            // choosenDirStatusStrip
            // 
            this.choosenDirStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelChoosenDir});
            this.choosenDirStatusStrip.Location = new System.Drawing.Point(0, 285);
            this.choosenDirStatusStrip.Name = "choosenDirStatusStrip";
            this.choosenDirStatusStrip.Size = new System.Drawing.Size(432, 22);
            this.choosenDirStatusStrip.TabIndex = 8;
            this.choosenDirStatusStrip.Text = "choosenDirStatusStrip";
            // 
            // toolStripStatusLabelChoosenDir
            // 
            this.toolStripStatusLabelChoosenDir.Name = "toolStripStatusLabelChoosenDir";
            this.toolStripStatusLabelChoosenDir.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabelChoosenDir.Text = "Select any archive";
            this.toolStripStatusLabelChoosenDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 307);
            this.Controls.Add(this.choosenDirStatusStrip);
            this.Controls.Add(this.showFileButton);
            this.Controls.Add(this.unarchivedItemsListBox);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.buttonPathSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.choosenDirStatusStrip.ResumeLayout(false);
            this.choosenDirStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPathSelect;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.ListBox unarchivedItemsListBox;
        private System.Windows.Forms.Button showFileButton;
        private System.Windows.Forms.StatusStrip choosenDirStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelChoosenDir;
    }
}

