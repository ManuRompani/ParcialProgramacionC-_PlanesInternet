using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacionManuelRompani.Exceptions
{
    public class ClienteExistException : Exception
    {
        public ClienteExistException(int dni) 
        :base($"Ya existe un Cliente con DNI {dni}")
        { }
    }
}
