using DevProjectManagement;
using DevProjectManagement.Repos;
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
                Allocation a = new Allocation();

                a.Developer = (Developer) lstDevelopers.SelectedItem;
                a.Project = (Project) lstProjects.SelectedItem;
                a.Beginning = dtpBeginning.Value;
                a.End = dtpEnd.Value;
                a.HoursPerWeek = Convert.ToByte(nupHoursOfWork.Value);
                a.Remuneration = Convert.ToByte(txtRemuneration.Text);

                AllocationRepository.Save(a);

                txtDeveloper.Clear();
                txtProject.Clear();
                lblDevSelected.Text = string.Empty;
                lblProjectSelected.Text = string.Empty;
                // lstDevelopers.Items.Clear();
                // lstDevelopers.ClearSelected();
                // lstProjects.Items.Clear();
                // lstProjects.ClearSelected();
                dtpBeginning.Value = DateTime.Now;
                dtpEnd.Value = DateTime.Now;
                nupHoursOfWork.Value = 0;
                txtRemuneration.Clear();

                MessageBox.Show("Saved successfully!", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
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
        }

        private void lstDevelopers_DoubleClick(object sender, EventArgs e)
        {
            Developer d = (Developer)lstDevelopers.SelectedItem;
            lblDevSelected.Text = "Name: " + d.Name + "\nBirth: " + d.Birth.ToShortDateString() + "\nLevel: "  + d.LevelDB;

        }

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            lstProjects.DataSource = ProjectRepository.FindByPartialName(txtProject.Text);
        }

        private void lstProjects_DoubleClick(object sender, EventArgs e)
        {
            Project p = (Project)lstProjects.SelectedItem;
            lblProjectSelected.Text = "Name: " + p.Name + "\nBeginning: " + p.Beginning.ToShortDateString() + "\nEnd: " + p.End.ToShortDateString() + "\nEnd Planned: " + p.EndPlanned.ToShortDateString();
        }
    }
}

