using DevProjectManagement;
using GestaoDesenvolvedoresEProjetos.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDesenvolvedoresEProjetos.GUIs
{
    public partial class FrmNewProject : Form
    {
        private FrmNewProject()
        {
            InitializeComponent();
        }

        private static FrmNewProject _instance;

        public static FrmNewProject GetInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmNewProject();
            }
            _instance.MdiParent = FrmMain.GetInstance();
            return _instance;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectRepository.AddProject(txtName.Text, dtpBeginning.Value, dtpEndPlanned.Value, dtpEnd.Value);
                txtName.Clear();
                dtpBeginning.Value = DateTime.Now;
                dtpEndPlanned.Value = DateTime.Now;
                dtpEnd.Value = DateTime.Now;
            }
            catch
            {
                MessageBox.Show("Fill all parameters!", ":C", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Clear();
                dtpBeginning.Value = DateTime.Now;
                dtpEndPlanned.Value = DateTime.Now;
                dtpEnd.Value = DateTime.Now;
            }
        }
    }
}
