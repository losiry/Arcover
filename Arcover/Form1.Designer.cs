namespace Arcover
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.openArchiveButton = new System.Windows.Forms.Button();
            this.openDictionaryButton = new System.Windows.Forms.Button();
            this.textBoxArchivePath = new System.Windows.Forms.TextBox();
            this.textBoxDictionaryPath = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioButtonDictionary = new System.Windows.Forms.RadioButton();
            this.radioButtonBruteforce = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.checkedListBoxBruteMode = new System.Windows.Forms.CheckedListBox();
            this.listViewLogger = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // openArchiveButton
            // 
            this.openArchiveButton.Location = new System.Drawing.Point(525, 10);
            this.openArchiveButton.Name = "openArchiveButton";
            this.openArchiveButton.Size = new System.Drawing.Size(158, 23);
            this.openArchiveButton.TabIndex = 0;
            this.openArchiveButton.Text = "Open Archive";
            this.openArchiveButton.UseVisualStyleBackColor = true;
            this.openArchiveButton.Click += new System.EventHandler(this.openArchiveButton_Click);
            // 
            // openDictionaryButton
            // 
            this.openDictionaryButton.Location = new System.Drawing.Point(525, 36);
            this.openDictionaryButton.Name = "openDictionaryButton";
            this.openDictionaryButton.Size = new System.Drawing.Size(158, 23);
            this.openDictionaryButton.TabIndex = 1;
            this.openDictionaryButton.Text = "Open Dictionary";
            this.openDictionaryButton.UseVisualStyleBackColor = true;
            this.openDictionaryButton.Click += new System.EventHandler(this.openDictionaryButton_Click);
            // 
            // textBoxArchivePath
            // 
            this.textBoxArchivePath.Location = new System.Drawing.Point(16, 12);
            this.textBoxArchivePath.Name = "textBoxArchivePath";
            this.textBoxArchivePath.Size = new System.Drawing.Size(503, 20);
            this.textBoxArchivePath.TabIndex = 2;
            // 
            // textBoxDictionaryPath
            // 
            this.textBoxDictionaryPath.Location = new System.Drawing.Point(16, 38);
            this.textBoxDictionaryPath.Name = "textBoxDictionaryPath";
            this.textBoxDictionaryPath.Size = new System.Drawing.Size(503, 20);
            this.textBoxDictionaryPath.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(503, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 15;
            // 
            // radioButtonDictionary
            // 
            this.radioButtonDictionary.AutoSize = true;
            this.radioButtonDictionary.Checked = true;
            this.radioButtonDictionary.Location = new System.Drawing.Point(525, 78);
            this.radioButtonDictionary.Name = "radioButtonDictionary";
            this.radioButtonDictionary.Size = new System.Drawing.Size(72, 17);
            this.radioButtonDictionary.TabIndex = 6;
            this.radioButtonDictionary.TabStop = true;
            this.radioButtonDictionary.Text = "Dictionary";
            this.radioButtonDictionary.UseVisualStyleBackColor = true;
            this.radioButtonDictionary.CheckedChanged += new System.EventHandler(this.radioButtonDictionary_CheckedChanged);
            // 
            // radioButtonBruteforce
            // 
            this.radioButtonBruteforce.AutoSize = true;
            this.radioButtonBruteforce.Location = new System.Drawing.Point(609, 78);
            this.radioButtonBruteforce.Name = "radioButtonBruteforce";
            this.radioButtonBruteforce.Size = new System.Drawing.Size(74, 17);
            this.radioButtonBruteforce.TabIndex = 7;
            this.radioButtonBruteforce.TabStop = true;
            this.radioButtonBruteforce.Text = "Bruteforce";
            this.radioButtonBruteforce.UseVisualStyleBackColor = true;
            this.radioButtonBruteforce.CheckedChanged += new System.EventHandler(this.radioButtonBruteforce_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(525, 361);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(158, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // checkedListBoxBruteMode
            // 
            this.checkedListBoxBruteMode.CheckOnClick = true;
            this.checkedListBoxBruteMode.FormattingEnabled = true;
            this.checkedListBoxBruteMode.Location = new System.Drawing.Point(525, 107);
            this.checkedListBoxBruteMode.Name = "checkedListBoxBruteMode";
            this.checkedListBoxBruteMode.Size = new System.Drawing.Size(158, 124);
            this.checkedListBoxBruteMode.TabIndex = 9;
            // 
            // listViewLogger
            // 
            this.listViewLogger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listViewLogger.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewLogger.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewLogger.Location = new System.Drawing.Point(16, 107);
            this.listViewLogger.Name = "listViewLogger";
            this.listViewLogger.Size = new System.Drawing.Size(503, 277);
            this.listViewLogger.TabIndex = 11;
            this.listViewLogger.UseCompatibleStateImageBehavior = false;
            this.listViewLogger.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 408);
            this.Controls.Add(this.listViewLogger);
            this.Controls.Add(this.checkedListBoxBruteMode);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.radioButtonBruteforce);
            this.Controls.Add(this.radioButtonDictionary);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxDictionaryPath);
            this.Controls.Add(this.textBoxArchivePath);
            this.Controls.Add(this.openDictionaryButton);
            this.Controls.Add(this.openArchiveButton);
            this.Name = "Form1";
            this.Text = "Arcover v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openArchiveButton;
        private System.Windows.Forms.Button openDictionaryButton;
        private System.Windows.Forms.TextBox textBoxArchivePath;
        private System.Windows.Forms.TextBox textBoxDictionaryPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButtonDictionary;
        private System.Windows.Forms.RadioButton radioButtonBruteforce;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckedListBox checkedListBoxBruteMode;
        private System.Windows.Forms.ListView listViewLogger;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

