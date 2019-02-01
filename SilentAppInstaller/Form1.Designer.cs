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
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonCheckForUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(51, 38);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(88, 13);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Current Version : ";
            // 
            // buttonCheckForUpdate
            // 
            this.buttonCheckForUpdate.Location = new System.Drawing.Point(54, 76);
            this.buttonCheckForUpdate.Name = "buttonCheckForUpdate";
            this.buttonCheckForUpdate.Size = new System.Drawing.Size(248, 48);
            this.buttonCheckForUpdate.TabIndex = 1;
            this.buttonCheckForUpdate.Text = "Check for Update";
            this.buttonCheckForUpdate.UseVisualStyleBackColor = true;
            this.buttonCheckForUpdate.Click += new System.EventHandler(this.ButtonCheckForUpdate_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 407);
            this.Controls.Add(this.buttonCheckForUpdate);
            this.Controls.Add(this.labelVersion);
            this.Name = "MainWindow";
            this.Text = "SilentAppInstaller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonCheckForUpdate;
    }
}

