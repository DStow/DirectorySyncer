namespace DirectorySyncer
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOriginPath = new System.Windows.Forms.TextBox();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOriginSelect = new System.Windows.Forms.Button();
            this.btnDestinationSelect = new System.Windows.Forms.Button();
            this.diagFolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory Syncer!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origin Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination Folder";
            // 
            // txtOriginPath
            // 
            this.txtOriginPath.Location = new System.Drawing.Point(12, 67);
            this.txtOriginPath.Name = "txtOriginPath";
            this.txtOriginPath.Size = new System.Drawing.Size(353, 29);
            this.txtOriginPath.TabIndex = 3;
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(12, 138);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(353, 29);
            this.txtDestinationPath.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 173);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(390, 38);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnOriginSelect
            // 
            this.btnOriginSelect.Location = new System.Drawing.Point(371, 67);
            this.btnOriginSelect.Name = "btnOriginSelect";
            this.btnOriginSelect.Size = new System.Drawing.Size(31, 29);
            this.btnOriginSelect.TabIndex = 6;
            this.btnOriginSelect.Text = "...";
            this.btnOriginSelect.UseVisualStyleBackColor = true;
            this.btnOriginSelect.Click += new System.EventHandler(this.btnOriginSelect_Click);
            // 
            // btnDestinationSelect
            // 
            this.btnDestinationSelect.Location = new System.Drawing.Point(371, 138);
            this.btnDestinationSelect.Name = "btnDestinationSelect";
            this.btnDestinationSelect.Size = new System.Drawing.Size(31, 29);
            this.btnDestinationSelect.TabIndex = 6;
            this.btnDestinationSelect.Text = "...";
            this.btnDestinationSelect.UseVisualStyleBackColor = true;
            this.btnDestinationSelect.Click += new System.EventHandler(this.btnDestinationSelect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 215);
            this.Controls.Add(this.btnDestinationSelect);
            this.Controls.Add(this.btnOriginSelect);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.txtOriginPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Directory Syncer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOriginPath;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOriginSelect;
        private System.Windows.Forms.Button btnDestinationSelect;
        private System.Windows.Forms.FolderBrowserDialog diagFolderSelect;
    }
}

