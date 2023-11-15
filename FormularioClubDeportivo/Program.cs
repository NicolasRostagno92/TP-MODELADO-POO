using System;
using System.Windows.Forms;

namespace FormularioClubDeportivo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear una instancia de frmPrincipal
            frmPrincipal principalForm = new frmPrincipal();

            // Pasar frmPrincipal como argumento al constructor de frmLogin
            Application.Run(new frmLogin(principalForm));
        }
    }
}
