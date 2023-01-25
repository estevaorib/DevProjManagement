using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevProjectManagement
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FrmLogin.GetInstance());

            //Allocation a = new Allocation(new DateTime(2020, 11, 23), new DateTime(2022, 11, 23), 5, 6000);

            //Project p = new Project();
            //p.Name = "Test";
            //p.Beginning = new DateTime(2020, 10, 23);
            //p.EndPlanned = new DateTime(2022, 10, 23);
            //p.End = new DateTime(2022, 11, 23);

            //Developer d = new Developer("Estevão", new DateTime(2006, 11, 23), 'P');

            //a.Developer = d;
            //a.Project = p;

            //Console.WriteLine(a.ToString());
        }
    }
}
