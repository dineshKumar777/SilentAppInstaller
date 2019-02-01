using System;
using System.Reflection;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using SilentAppInstaller.Properties;

namespace SilentAppInstaller
{
    public partial class MainWindow : Form
    {
        private const string UpdateLink = "https://raw.githack.com/dineshKumar777/SilentAppInstaller/master/SilentAppInstaller/VersionInfo.xml";

        public MainWindow()
        {
            InitializeComponent();
            labelVersion.Text = string.Format(Resources.CurrentVersion, Assembly.GetEntryAssembly().GetName().Version);
        }

        private void ButtonCheckForUpdate_Click(object sender, EventArgs e)
        {
            AutoUpdater.Mandatory = true;
            AutoUpdater.Start(UpdateLink);
        }
    }
}
