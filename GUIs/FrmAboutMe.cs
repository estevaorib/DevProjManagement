using DevProjectManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevProjectManagement.GUIs
{
    public partial class FrmAboutMe : Form
    {
        private FrmAboutMe()
        {
            InitializeComponent();
        }

        private static FrmAboutMe _instance;

        public static FrmAboutMe GetInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmAboutMe();
            }
            _instance.MdiParent = FrmMain.ActiveForm;
            return _instance;
        }
    }
}
