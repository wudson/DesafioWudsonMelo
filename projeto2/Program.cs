using System;
using System.Windows.Forms;
using projeto2.Login;

namespace projeto2
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ClasseComVariaveisGlobais.UsarDevExpress = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(!ClasseComVariaveisGlobais.UsarDev)
                Application.Run(new FrmEntrar());
            else 
                Application.Run(new FrmEntrarDev());
        }
    }
}