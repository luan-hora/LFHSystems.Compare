using LFHSystems.Compare.FolderComparison.Core;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LFHSystems.Compare.FolderComparison
{
    public partial class MainPage : Form
    {
        public MainPage()
        {            
            InitializeComponent();
        }

        private void btnCompareFolders_Click(object sender, EventArgs e)
        {
            string firstPath = txtFirstFolderPath.Text;
            string secondPath = txtSecondFolderPath.Text;
            string pathCopyFiles = txtFolderToCopyFiles.Text;

            StringBuilder strMissing = new StringBuilder();
            StringBuilder strDifferent = new StringBuilder();

            int totalDifferences = 0;
            int totalMissing = 0;

            DirectoryInfo directoryInfo1 = new DirectoryInfo(firstPath);
            DirectoryInfo directoryInfo2 = new DirectoryInfo(secondPath);

            bool found;
            try
            {
                FolderCompare compare = new FolderCompare(firstPath, secondPath, pathCopyFiles);

                foreach (FileInfo file in directoryInfo1.GetFiles())
                {
                    found = false;
                    foreach (FileInfo fileCompare in directoryInfo2.GetFiles())
                    {
                        if (found = compare.CheckFileExistInBothFolders(file, fileCompare))
                        {
                            if (compare.CompareFileSizeAndLastDate(file, fileCompare))
                            {
                                strDifferent.AppendLine(file.Name);
                                totalDifferences++;
                            }                            
                            else if(compare.CompareLastChangedDate(file, fileCompare))
                            {
                                strDifferent.AppendLine(file.Name);
                                totalDifferences++;
                            }
                            else if (compare.CompareFileSize(file, fileCompare))
                            {
                                strDifferent.AppendLine(file.Name);
                                totalDifferences++;
                            }
                                                       
                            break;
                        }

                        if (!found)
                        {
                            strMissing.AppendLine(file.Name);
                            totalDifferences++;                           
                            totalMissing++;
                        }
                    }
                }

                txtDifferentFiles.Text = $"TOTAL: {totalDifferences} {Environment.NewLine} {strDifferent}";
                txtMissingFiles.Text = $"TOTAL: {totalMissing} {Environment.NewLine} {strMissing}";
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        private void btnChooseFirstFolder_Click(object sender, EventArgs e)
        {
            if (fbdChoosePath.ShowDialog() == DialogResult.OK)
                txtFirstFolderPath.Text = fbdChoosePath.SelectedPath;
        }

        private void btnChooseSecondFolder_Click(object sender, EventArgs e)
        {
            if (fbdChoosePath.ShowDialog() == DialogResult.OK)
                txtSecondFolderPath.Text = fbdChoosePath.SelectedPath;
        }

        private void btnChooseCopyToFolder_Click(object sender, EventArgs e)
        {
            if (fbdChoosePath.ShowDialog() == DialogResult.OK)
                txtFolderToCopyFiles.Text = fbdChoosePath.SelectedPath;
        }
    }
}
