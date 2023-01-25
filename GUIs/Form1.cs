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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Form1 _instance;

        public static Form1 GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Form1();
            }
            return _instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Repository r = new Repository();
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            if(Credential.Authenticate(txtEmail.Text, txtPassword.Text))
            {
                this.Hide();
                FrmMain.GetInstance();
            }
        }
    }
}
