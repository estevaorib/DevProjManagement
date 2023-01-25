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
    public partial class FrmLogin : Form
    {
        private FrmLogin()
        {
            InitializeComponent();
        }

        private static FrmLogin _instance;

        public static FrmLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmLogin();
            }
            return _instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Repository r = new Repository();
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            Developer devLogged = CredentialRepository.Authenticate(txtEmail.Text, txtPassword.Text);

            if (devLogged != null)
            {
                txtEmail.Clear();
                txtPassword.Clear();
                this.Hide();
                FrmMain.DeveloperLogged = devLogged;
                FrmMain.GetInstance().Show();
            }
            else
            {
                txtEmail.Clear();
                txtPassword.Clear();

                MessageBox.Show("Incorret email &/or password!", ":C", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
