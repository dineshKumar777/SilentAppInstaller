namespace SilentAppInstaller
{
    partial class MainWindow
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
            this.FilePath = new System.Windows.Forms.Button();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.SelectFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.Color.GreenYellow;
            this.FilePath.ForeColor = System.Drawing.Color.DarkOrchid;
            this.FilePath.Location = new System.Drawing.Point(12, 12);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(250, 34);
            this.FilePath.TabIndex = 9;
            this.FilePath.Text = "FilePath";
            this.FilePath.UseVisualStyleBackColor = false;
            this.FilePath.Click += new System.EventHandler(this.FilePath_Click);
            // 
            // MainTreeView
            // 
            this.MainTreeView.AllowDrop = true;
            this.MainTreeView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MainTreeView.CheckBoxes = true;
            this.MainTreeView.FullRowSelect = true;
            this.MainTreeView.HotTracking = true;
            this.MainTreeView.Location = new System.Drawing.Point(12, 121);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.ShowPlusMinus = false;
            this.MainTreeView.Size = new System.Drawing.Size(423, 450);
            this.MainTreeView.TabIndex = 10;
            // 
            // SelectFiles
            // 
            this.SelectFiles.BackColor = System.Drawing.Color.GreenYellow;
            this.SelectFiles.Enabled = false;
            this.SelectFiles.ForeColor = System.Drawing.Color.DarkOrchid;
            this.SelectFiles.Location = new System.Drawing.Point(12, 577);
            this.SelectFiles.Name = "SelectFiles";
            this.SelectFiles.Size = new System.Drawing.Size(423, 35);
            this.SelectFiles.TabIndex = 11;
            this.SelectFiles.Text = "SelectFiles";
            this.SelectFiles.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 639);
            this.Controls.Add(this.SelectFiles);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.FilePath);
            this.Name = "MainWindow";
            this.Text = "SilentAppInstaller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FilePath;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.Button SelectFiles;
    }
}

