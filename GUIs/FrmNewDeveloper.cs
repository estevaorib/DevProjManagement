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
    public partial class FrmNewDeveloper : Form
    {
        private FrmNewDeveloper()
        {
            InitializeComponent();
            cbxLevel.Items.Add('J');
            cbxLevel.Items.Add('F');
            cbxLevel.Items.Add('S');
        }

        private static FrmNewDeveloper _instance;

        public static FrmNewDeveloper GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmNewDeveloper();
            }
            _instance.MdiParent = FrmMain.GetInstance();
            return _instance;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(CredentialRepository.FindByEmail(txtEmail.Text) != null)
                {
                    MessageBox.Show("This email already exists!", ":C", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(txtPassword.Text.Length >= 8 && txtPassword.Text.Length <= 12 && txtEmail != null)
                    {
                        Developer d = new Developer();
                        d.Name = txtName.Text;
                        d.Birth = dtpBirth.Value;
                        d.Level = Convert.ToChar(cbxLevel.Text);
                        
                        Credential c = new Credential();
                        c.Email = txtEmail.Text;
                        c.Password = txtPassword.Text;
                        c.Active = cbxActive.Checked;
                        c.Administrator = cbxAdmin.Checked;

                        d.Credential = c;
                        c.Developer = d;

                        DeveloperRepository.Save(d);

                        txtName.Clear();
                        dtpBirth.Value = DateTime.Now;
                        cbxLevel.SelectedIndex = -1;
                        txtEmail.Clear();
                        txtPassword.Clear();
                        cbxActive.Checked = false;
                        cbxAdmin.Checked = false;

                        MessageBox.Show("Saved successfully!", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password!", ":C", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fill all parameters!", "Something went wrong :C", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
