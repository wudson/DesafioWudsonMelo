﻿using System;
using System.Windows.Forms;

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
            //ClasseComVariaveisGlobais.UsarDevExpress = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEntrar());
        }
    }
}