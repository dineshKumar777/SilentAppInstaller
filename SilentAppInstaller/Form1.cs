using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using SilentAppInstaller.Properties;

namespace SilentAppInstaller
{
    public partial class MainWindow : Form
    {
        private const string UpdateLink = "https://raw.githack.com/dineshKumar777/SilentAppInstaller/master/SilentAppInstaller/VersionInfo.xml";
        private string softwaresFolderPath = Path.Combine(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), Constant.SOFTWARE_SETUP));

        public MainWindow()
        {
            InitializeComponent();
            string versionNum = string.Format(Resources.CurrentVersion, Assembly.GetEntryAssembly().GetName().Version);
            AutoUpdater.Start(UpdateLink);
        }

        private void ButtonCheckForUpdate_Click(object sender, EventArgs e)
        {
            AutoUpdater.Mandatory = true;
            AutoUpdater.Start(UpdateLink);
        }

        private void FilePath_Click(object sender, EventArgs e)
        {
            //int offset = 0;
            //if(Directory.Exists(softwaresFolderPath))
            //{
            //    foreach (var listofFolders in Directory.GetDirectories(softwaresFolderPath))
            //    {
            //        var softwareFolderName = listofFolders.Split('\\').Last();
            //        RadioButton radio_btn = new RadioButton { Name = softwareFolderName, Text = softwareFolderName, Width = 120, Height = 30, AutoCheck = true, Location = new System.Drawing.Point(50 + (offset), 50) };
            //        Controls.Add(radio_btn);
            //        offset += 120;
            //        radio_btn.CheckedChanged += new EventHandler(RadioButton_Checked);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(Constant.DIRECTORY_NOT_FOUND);
            //}
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            //RadioButton radio_btn = (sender as RadioButton);
            //if(radio_btn.Checked)
            //{
                
            //}
        }
    }
}
