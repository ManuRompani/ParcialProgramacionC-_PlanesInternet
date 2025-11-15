using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacionManuelRompani.Exceptions
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(string valueName) 
            : base($"El valor del campo {valueName} no puede ser negativo."){ }
    }
}
