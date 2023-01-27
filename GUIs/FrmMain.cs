using DevProjectManagement.GUIs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevProjectManagement
{
    public partial class FrmMain : Form
    {
        private FrmMain()
        {
            InitializeComponent();
        }

        public static Developer DeveloperLogged { get; set; }

        private static FrmMain _instance;

        public static FrmMain GetInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmMain();
            }
            return _instance;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewDeveloper.GetInstance().Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin.GetInstance().Show();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNewProject.GetInstance().Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (DeveloperLogged.Credential.Administrator)
            {
                mnuDev.Enabled = true;
                mnuProject.Enabled = true;
            }
            else
            {
                mnuDev.Enabled = false;
                mnuProject.Enabled = false;
            }
        }

        private void mnuAboutMe_Click(object sender, EventArgs e)
        {
            FrmAboutMe.GetInstance().Show();
        }

        private void mnuAddNewAllocation_Click(object sender, EventArgs e)
        {
            FrmNewAllocation.GetInstance().Show();
        }
    }
}
