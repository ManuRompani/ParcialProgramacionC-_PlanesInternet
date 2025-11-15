using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacionManuelRompani.Modelo
{
    public class PlanWifi
    {
        public string Nombre { get; set; }
        public double CostoMensual { get; set; }
        public double CostoGbExtra { get; set; }

        public PlanWifi(string nombre, double costoMensual, double costoGbExtra)
        {
            Nombre = nombre;
            CostoMensual = costoMensual;
            CostoGbExtra = costoGbExtra;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
