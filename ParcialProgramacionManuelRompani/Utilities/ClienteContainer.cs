using ParcialProgramacionManuelRompani.Exceptions;
using ParcialProgramacionManuelRompani.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacionManuelRompani.Utilities
{
    public class ClienteContainer
    {
        private List<Cliente> _listaClientes;

        public ClienteContainer()
        {
            _listaClientes = new List<Cliente>();
        }

        public void Agregar(Cliente nuevoCliente)
        {
            if (nuevoCliente.GbConsumidos < 0)
                throw new NegativeValueException("GB Consumidos");

            if (GetClienteByDNI(nuevoCliente.DNI) != null)
                throw new ClienteExistException(nuevoCliente.DNI);

            _listaClientes.Add(nuevoCliente);
        }

        public Cliente GetClienteByDNI(int dni)
        {
            Cliente clienteEncontrado = null;

            foreach(Cliente cliente in _listaClientes)
            {
                if(cliente.DNI == dni)
                {
                    clienteEncontrado = cliente;
                    break;
                }
            }

            return clienteEncontrado;
        }

        public List<Cliente> GetTodos()
        {
            return new List<Cliente>(_listaClientes);
        }

        public Cliente GetClienteMasPaga()
        {
            Cliente clienteEncontrado = null;

            foreach(Cliente cliente in _listaClientes)
            {
                if(clienteEncontrado == null || cliente.Total > clienteEncontrado.Total)
                {
                    clienteEncontrado = cliente;
                }  
            }

            return clienteEncontrado;
        }

        public double PromedioCostoTotalMensualClientesNormales()
        {
            double total = 0;
            int cantidadClientesNormales = 0;

            foreach(Cliente cliente in _listaClientes) 
            { 
                if(cliente.TipoCliente == "Normal")
                {
                    cantidadClientesNormales++;
                    total += cliente.Total;
                }
            }

            if (cantidadClientesNormales >= 1)
                return total / cantidadClientesNormales;

            return total;
        }

        public List<Cliente> GetClientesConsumoMayor15GB()
        {
            List<Cliente> clientesEncontrados = new List<Cliente>();

            foreach(Cliente cliente in _listaClientes)
            {
                if(cliente.GbConsumidos > 15)
                {
                    clientesEncontrados.Add(cliente);
                }
            }

            return clientesEncontrados;
        }
    }
}
