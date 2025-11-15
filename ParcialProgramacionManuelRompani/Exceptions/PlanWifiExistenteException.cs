using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacionManuelRompani.Exceptions
{
    public class PlanWifiExistenteException : Exception
    {
        public PlanWifiExistenteException(string nombre)
        :base($"Ya existe un plan de wifi con nombre {nombre}")
        {
        }
    }
}
