using System;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace SilentAppInstaller
{
    public partial class Form1 : Form
    {
        private const string UpdateLink = "https://rbsoft.org/updates/AutoUpdaterTest.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCheckForUpdate_Click(object sender, EventArgs e)
        {
            AutoUpdater.Mandatory = true;
            AutoUpdater.Start(UpdateLink);
        }
    }
}
