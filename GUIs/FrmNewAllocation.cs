using DevProjectManagement;
using GestaoDesenvolvedoresEProjetos.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevProjectManagement
{
    public partial class FrmNewAllocation : Form
    {
        private FrmNewAllocation()
        {
            InitializeComponent();

        }

        private static FrmNewAllocation _instance;

        public static FrmNewAllocation GetInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmNewAllocation();
            }
            _instance.MdiParent = FrmMain.GetInstance();
            return _instance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(lstDevelopers.SelectedItems.Count > 0 && lstProjects.SelectedItems.Count > 0)
                {
                    AllocationRepository.AddAllocation((Developer)lstDevelopers.SelectedItem, (Project)lstProjects.SelectedItem, dtpBeginning.Value, dtpEnd.Value, Convert.ToByte(nupHoursOfWork.Value), Convert.ToByte(txtRemuneration.Text));
                    
                    //txtDeveloper.Clear();
                    //txtProject.Clear();
                    //lstDevelopers.Items.Clear();
                    //lstDevelopers.ClearSelected();
                    //lstProjects.Items.Clear();
                    //lstProjects.ClearSelected();
                    //dtpBeginning.Value = DateTime.Now;
                    //dtpEnd.Value = DateTime.Now;
                    //nupHoursOfWork.Value = 0;
                    //txtRemuneration.Clear();
                }
                else
                {
                    MessageBox.Show("Select a developer &/or a project!!", "Something went wrong :C", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fill all parameters!", "Something went wrong :C", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDeveloper_TextChanged(object sender, EventArgs e)
        {
            if(txtDeveloper.Text != null)
            {
                lstDevelopers.DataSource = DeveloperRepository.FindByPartialName(txtDeveloper.Text);
            }
            else
            {
                lstDevelopers.Items.Clear();
            }
        }

        private void lstDevelopers_DoubleClick(object sender, EventArgs e)
        {
            lblDevSelected.Text = lstDevelopers.SelectedItem.ToString();
        }

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            lstProjects.DataSource = ProjectRepository.FindByPartialName(txtProject.Text);
        }

        private void lstProjects_DoubleClick(object sender, EventArgs e)
        {
            lblProjectSelected.Text = lstProjects.SelectedItem.ToString();
        }
    }
}
