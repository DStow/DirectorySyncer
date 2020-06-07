using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DirectorySyncer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOriginSelect_Click(object sender, EventArgs e)
        {
            // Get the path from the folder select dialog
            string path = GetDirectoryPath("Origin");

            // A path was not provided so don't continue
            if (path == null)
                return;

            // Set the textbox to the path provided
            txtOriginPath.Text = path;
        }

        private void btnDestinationSelect_Click(object sender, EventArgs e)
        {
            // Get the path from the folder select dialog
            string path = GetDirectoryPath("Destination");

            // A path was not provided so don't continue
            if (path == null)
                return;

            // Set the textbox to the path provided
            txtDestinationPath.Text = path;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string originPath = txtOriginPath.Text;
            string destPath = txtDestinationPath.Text;

            // Check both paths exist
            if (Directory.Exists(originPath) == false)
            {
                MessageBox.Show("Origin directory does not exist!");
                return;
            }

            if (Directory.Exists(destPath) == false)
            {
                MessageBox.Show("Destination directory does not exist!");
                return;
            }

            // Check both paths are not the same or children of each other
            if (originPath.Contains(destPath) || destPath.Contains(originPath))
            {
                // This will also catch if they are the same
                MessageBox.Show("Directories cannot exist within each other or be the same!");
                return;
            }

            // Time to start the copy procedure from the root foler
            FolderTransfer(originPath, destPath);
        }

        /// <summary>
        /// Shows the user the diagFolderSelect, displaying a relevant prompt at the bottom of the dialog
        /// </summary>
        /// <param name="pathName">Name that describes what path the user is selecting</param>
        /// <returns>Null if dialog cancelled else the path</returns>
        private string GetDirectoryPath(string pathName)
        {
            diagFolderSelect.SelectedPath = "Select " + pathName + " folder";

            if (diagFolderSelect.ShowDialog() == DialogResult.OK)
            {
                return diagFolderSelect.SelectedPath;
            }

            return null;
        }

        private void FolderTransfer(string originPath, string destPath)
        {
            // Check dest path exists
            if (Directory.Exists(destPath) == false)
                Directory.CreateDirectory(destPath);

            // #### Copy files
            string[] originFiles = Directory.GetFiles(originPath);

            foreach (string originFile in originFiles)
            {
                // Get just the file name to build up the destination file name
                string fileName = Path.GetFileName(originFile);

                // Equivelent file path in the destinatiom directory
                string destinationFile = destPath + "\\" + fileName;

                // Check if destination file exists
                if (File.Exists(destinationFile))
                {
                    // Check last modified date
                    DateTime originLastModified = File.GetLastWriteTimeUtc(originFile);
                    DateTime destinationLastModified = File.GetLastWriteTimeUtc(destinationFile);

                    // Origin file is newer, take the newest one
                    if (originLastModified > destinationLastModified)
                    {
                        File.Copy(originFile, destinationFile, true);
                    }
                    else
                    {
                        // If we want to deal with collisions we could do it here there
                    }
                }
                else // File does not exist so just copy it
                {
                    // Copy the file
                    File.Copy(originFile, destinationFile);
                }
            }


            // #### Copy Directories
            // Time to loop through the directories and pull back in for the next round
            foreach (string originSubDirectory in Directory.GetDirectories(originPath))
            {
                // Get the sub folder by getting last folder in path
                string newSubPath = originSubDirectory.Substring(originSubDirectory.LastIndexOf("\\"));

                // Kick off the folder transfer again now we have a new directory to crunch through
                FolderTransfer(originSubDirectory, destPath + newSubPath);
            }
        }
    }
}
