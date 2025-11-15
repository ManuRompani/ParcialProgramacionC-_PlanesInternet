using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacionManuelRompani.Modelo
{
    public class Cliente
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        //Plus, Normal, Libre
        public string TipoCliente { get; set; }
        public PlanWifi PlanWifi { get; set; }
        public int GbConsumidos { get; set; }
        public double Total { get => this.getTotal(); }


        public Cliente(int dni, string nombre, string tipoCliente, PlanWifi planWifi, int gbConsumidos)
        {
            DNI = dni;
            Nombre = nombre;
            TipoCliente = tipoCliente;
            PlanWifi = planWifi;
            GbConsumidos = gbConsumidos;
        }

        private double getTotal()
        {
            return this.PlanWifi.CostoMensual + (this.PlanWifi.CostoGbExtra * this.GetGbExcedente());
        }

        public int GetGbExcedente()
        {
            //Normal 10
            //Plus 30
            //Libre libre
            int excedente = 0;

            switch (this.TipoCliente)
            {
                case "Plus":
                    excedente = this.GbConsumidos > 30 ? this.GbConsumidos - 30 : 0;
                    break;
                case "Normal":
                    excedente = this.GbConsumidos > 10 ? this.GbConsumidos - 10 : 0;
                    break;
            }

            return excedente;
        }
    }
}
