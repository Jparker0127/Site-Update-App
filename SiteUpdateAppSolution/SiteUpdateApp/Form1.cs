using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace SiteUpdateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectBuild_Click(object sender, EventArgs e)
        {
            string buildPath = "";
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                buildPath = ofd.FileName;
                lblBuild.Text = buildPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            // Create window to browse for folder to backup
            using (FolderBrowserDialog fbd = new FolderBrowserDialog()) {
                fbd.Description = "Select folder to zip.";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string sourceFolder = fbd.SelectedPath;
                    string zipPath = Path.Combine(Path.GetDirectoryName(sourceFolder), 
                        Path.GetFileName(sourceFolder) + "_backup.zip");

                    // Future functionality -Delete old Backups-

                    ZipFile.CreateFromDirectory(sourceFolder, zipPath);
                    MessageBox.Show($"Folder zipped successfully to:\n{zipPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
