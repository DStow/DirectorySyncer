using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /// <summary>
        /// Shows the user the diagFolderSelect, displaying a relevant prompt at the bottom of the dialog
        /// </summary>
        /// <param name="pathName">Name that describes what path the user is selecting</param>
        /// <returns>Null if dialog cancelled else the path</returns>
        private string GetDirectoryPath(string pathName)
        {
            diagFolderSelect.SelectedPath = "Select " + pathName + " folder";
            
            if(diagFolderSelect.ShowDialog() == DialogResult.OK)
            {
                return diagFolderSelect.SelectedPath;
            }

            return null;
        }
    }
}
