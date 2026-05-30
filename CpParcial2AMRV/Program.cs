using System;
using System.Windows.Forms;

namespace CpParcial2AMRV
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrograma());
        }
    }
}
