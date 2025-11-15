using ParcialProgramacionManuelRompani.Exceptions;
using ParcialProgramacionManuelRompani.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacionManuelRompani.Utilities
{
    public class PlanWifiContainer
    {
        private List<PlanWifi> _listaPlanWifi;

        public PlanWifiContainer()
        {
            _listaPlanWifi = new List<PlanWifi>();
        }

        public void Agregar(PlanWifi nuevoPlan)
        {
            if (GetByNombre(nuevoPlan.Nombre) != null)
                throw new PlanWifiExistenteException(nuevoPlan.Nombre);

            if (nuevoPlan.CostoMensual < 0)
                throw new NegativeValueException("Costo Mensual");

            if (nuevoPlan.CostoGbExtra < 0)
                throw new NegativeValueException("Costo por GB extra");

            _listaPlanWifi.Add(nuevoPlan);
        }

        public List<PlanWifi> GetTodo()
        {
            return new List<PlanWifi>(_listaPlanWifi);
        }

        public PlanWifi GetByNombre(string nombre)
        {
            PlanWifi planEncontrado = null;

            foreach(PlanWifi plan in _listaPlanWifi)
            {
                if(plan.Nombre == nombre)
                {
                    planEncontrado = plan;
                }
            }

            return planEncontrado;
        }
    }
}
