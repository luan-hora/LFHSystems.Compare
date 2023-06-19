
namespace LFHSystems.Compare.FolderComparison
{
    partial class MainPage
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
            this.txtFirstFolderPath = new System.Windows.Forms.TextBox();
            this.lblFirstFolder = new System.Windows.Forms.Label();
            this.txtSecondFolderPath = new System.Windows.Forms.TextBox();
            this.lblSecondFolder = new System.Windows.Forms.Label();
            this.btnCompareFolders = new System.Windows.Forms.Button();
            this.txtDifferentFiles = new System.Windows.Forms.TextBox();
            this.lblDifferentFiles = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.txtMissingFiles = new System.Windows.Forms.TextBox();
            this.lblMissingFiles = new System.Windows.Forms.Label();
            this.lblFolderToCopyFiles = new System.Windows.Forms.Label();
            this.txtFolderToCopyFiles = new System.Windows.Forms.TextBox();
            this.fbdChoosePath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseFirstFolder = new System.Windows.Forms.Button();
            this.btnChooseSecondFolder = new System.Windows.Forms.Button();
            this.btnChooseCopyToFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstFolderPath
            // 
            this.txtFirstFolderPath.Enabled = false;
            this.txtFirstFolderPath.Location = new System.Drawing.Point(13, 57);
            this.txtFirstFolderPath.Name = "txtFirstFolderPath";
            this.txtFirstFolderPath.Size = new System.Drawing.Size(174, 20);
            this.txtFirstFolderPath.TabIndex = 0;
            // 
            // lblFirstFolder
            // 
            this.lblFirstFolder.AutoSize = true;
            this.lblFirstFolder.Location = new System.Drawing.Point(13, 38);
            this.lblFirstFolder.Name = "lblFirstFolder";
            this.lblFirstFolder.Size = new System.Drawing.Size(58, 13);
            this.lblFirstFolder.TabIndex = 1;
            this.lblFirstFolder.Text = "First Folder";
            // 
            // txtSecondFolderPath
            // 
            this.txtSecondFolderPath.Enabled = false;
            this.txtSecondFolderPath.Location = new System.Drawing.Point(228, 57);
            this.txtSecondFolderPath.Name = "txtSecondFolderPath";
            this.txtSecondFolderPath.Size = new System.Drawing.Size(174, 20);
            this.txtSecondFolderPath.TabIndex = 2;
            // 
            // lblSecondFolder
            // 
            this.lblSecondFolder.AutoSize = true;
            this.lblSecondFolder.Location = new System.Drawing.Point(259, 38);
            this.lblSecondFolder.Name = "lblSecondFolder";
            this.lblSecondFolder.Size = new System.Drawing.Size(76, 13);
            this.lblSecondFolder.TabIndex = 3;
            this.lblSecondFolder.Text = "Second Folder";
            // 
            // btnCompareFolders
            // 
            this.btnCompareFolders.Location = new System.Drawing.Point(296, 94);
            this.btnCompareFolders.Name = "btnCompareFolders";
            this.btnCompareFolders.Size = new System.Drawing.Size(106, 23);
            this.btnCompareFolders.TabIndex = 4;
            this.btnCompareFolders.Text = "Compare";
            this.btnCompareFolders.UseVisualStyleBackColor = true;
            this.btnCompareFolders.Click += new System.EventHandler(this.btnCompareFolders_Click);
            // 
            // txtDifferentFiles
            // 
            this.txtDifferentFiles.Location = new System.Drawing.Point(13, 153);
            this.txtDifferentFiles.Multiline = true;
            this.txtDifferentFiles.Name = "txtDifferentFiles";
            this.txtDifferentFiles.Size = new System.Drawing.Size(355, 219);
            this.txtDifferentFiles.TabIndex = 5;
            // 
            // lblDifferentFiles
            // 
            this.lblDifferentFiles.AutoSize = true;
            this.lblDifferentFiles.Location = new System.Drawing.Point(13, 137);
            this.lblDifferentFiles.Name = "lblDifferentFiles";
            this.lblDifferentFiles.Size = new System.Drawing.Size(71, 13);
            this.lblDifferentFiles.TabIndex = 6;
            this.lblDifferentFiles.Text = "Different Files";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(476, 57);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 7;
            // 
            // txtMissingFiles
            // 
            this.txtMissingFiles.Location = new System.Drawing.Point(415, 153);
            this.txtMissingFiles.Multiline = true;
            this.txtMissingFiles.Name = "txtMissingFiles";
            this.txtMissingFiles.Size = new System.Drawing.Size(355, 219);
            this.txtMissingFiles.TabIndex = 8;
            // 
            // lblMissingFiles
            // 
            this.lblMissingFiles.AutoSize = true;
            this.lblMissingFiles.Location = new System.Drawing.Point(412, 137);
            this.lblMissingFiles.Name = "lblMissingFiles";
            this.lblMissingFiles.Size = new System.Drawing.Size(66, 13);
            this.lblMissingFiles.TabIndex = 9;
            this.lblMissingFiles.Text = "Missing Files";
            // 
            // lblFolderToCopyFiles
            // 
            this.lblFolderToCopyFiles.AutoSize = true;
            this.lblFolderToCopyFiles.Enabled = false;
            this.lblFolderToCopyFiles.Location = new System.Drawing.Point(13, 80);
            this.lblFolderToCopyFiles.Name = "lblFolderToCopyFiles";
            this.lblFolderToCopyFiles.Size = new System.Drawing.Size(75, 13);
            this.lblFolderToCopyFiles.TabIndex = 10;
            this.lblFolderToCopyFiles.Text = "Copy to Folder";
            // 
            // txtFolderToCopyFiles
            // 
            this.txtFolderToCopyFiles.Enabled = false;
            this.txtFolderToCopyFiles.Location = new System.Drawing.Point(13, 97);
            this.txtFolderToCopyFiles.Name = "txtFolderToCopyFiles";
            this.txtFolderToCopyFiles.Size = new System.Drawing.Size(174, 20);
            this.txtFolderToCopyFiles.TabIndex = 11;
            // 
            // fbdChoosePath
            // 
            this.fbdChoosePath.Description = "...";
            this.fbdChoosePath.ShowNewFolderButton = false;
            this.fbdChoosePath.Tag = "...";
            // 
            // btnChooseFirstFolder
            // 
            this.btnChooseFirstFolder.Location = new System.Drawing.Point(193, 57);
            this.btnChooseFirstFolder.Name = "btnChooseFirstFolder";
            this.btnChooseFirstFolder.Size = new System.Drawing.Size(29, 20);
            this.btnChooseFirstFolder.TabIndex = 12;
            this.btnChooseFirstFolder.Text = "...";
            this.btnChooseFirstFolder.UseVisualStyleBackColor = true;
            this.btnChooseFirstFolder.Click += new System.EventHandler(this.btnChooseFirstFolder_Click);
            // 
            // btnChooseSecondFolder
            // 
            this.btnChooseSecondFolder.Location = new System.Drawing.Point(408, 57);
            this.btnChooseSecondFolder.Name = "btnChooseSecondFolder";
            this.btnChooseSecondFolder.Size = new System.Drawing.Size(29, 20);
            this.btnChooseSecondFolder.TabIndex = 13;
            this.btnChooseSecondFolder.Text = "...";
            this.btnChooseSecondFolder.UseVisualStyleBackColor = true;
            this.btnChooseSecondFolder.Click += new System.EventHandler(this.btnChooseSecondFolder_Click);
            // 
            // btnChooseCopyToFolder
            // 
            this.btnChooseCopyToFolder.Location = new System.Drawing.Point(193, 97);
            this.btnChooseCopyToFolder.Name = "btnChooseCopyToFolder";
            this.btnChooseCopyToFolder.Size = new System.Drawing.Size(29, 20);
            this.btnChooseCopyToFolder.TabIndex = 14;
            this.btnChooseCopyToFolder.Text = "...";
            this.btnChooseCopyToFolder.UseVisualStyleBackColor = true;
            this.btnChooseCopyToFolder.Click += new System.EventHandler(this.btnChooseCopyToFolder_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChooseCopyToFolder);
            this.Controls.Add(this.btnChooseSecondFolder);
            this.Controls.Add(this.btnChooseFirstFolder);
            this.Controls.Add(this.txtFolderToCopyFiles);
            this.Controls.Add(this.lblFolderToCopyFiles);
            this.Controls.Add(this.lblMissingFiles);
            this.Controls.Add(this.txtMissingFiles);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblDifferentFiles);
            this.Controls.Add(this.txtDifferentFiles);
            this.Controls.Add(this.btnCompareFolders);
            this.Controls.Add(this.lblSecondFolder);
            this.Controls.Add(this.txtSecondFolderPath);
            this.Controls.Add(this.lblFirstFolder);
            this.Controls.Add(this.txtFirstFolderPath);
            this.Name = "MainPage";
            this.Text = "Folders Comparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstFolderPath;
        private System.Windows.Forms.Label lblFirstFolder;
        private System.Windows.Forms.TextBox txtSecondFolderPath;
        private System.Windows.Forms.Label lblSecondFolder;
        private System.Windows.Forms.Button btnCompareFolders;
        private System.Windows.Forms.TextBox txtDifferentFiles;
        private System.Windows.Forms.Label lblDifferentFiles;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox txtMissingFiles;
        private System.Windows.Forms.Label lblMissingFiles;
        private System.Windows.Forms.Label lblFolderToCopyFiles;
        private System.Windows.Forms.TextBox txtFolderToCopyFiles;
        private System.Windows.Forms.FolderBrowserDialog fbdChoosePath;
        private System.Windows.Forms.Button btnChooseFirstFolder;
        private System.Windows.Forms.Button btnChooseSecondFolder;
        private System.Windows.Forms.Button btnChooseCopyToFolder;
    }
}

