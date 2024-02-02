using AGE.Vue.Formulaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Resources;
using AGE.Vue.Formulaire.Aceuille;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;



namespace AGE
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

         


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSplashScreen());
            SqlClientLogger Logger = new SqlClientLogger();
            
        }
    }
}
