using ParcialProgramacionManuelRompani.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialProgramacionManuelRompani
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ClienteContainer clienteContainer = new ClienteContainer();
            PlanWifiContainer planWifiContainer = new PlanWifiContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1(clienteContainer, planWifiContainer));
        }
    }
}
