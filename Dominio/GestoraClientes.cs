using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class GestoraClientes
    {
        private List<Cliente> colClientes;
        private static GestoraClientes instanciaGestora = null;

        public GestoraClientes()
        {
            colClientes = new List<Cliente>();
        }

        public static GestoraClientes Instancia
        {
            get
            {
                if (instanciaGestora == null)
                {
                    instanciaGestora = new GestoraClientes();
                }
                return instanciaGestora;
            }
        }

        public List<Cliente> Clientes
        {
            get
            {
                return new List<Cliente>(colClientes);
            }
        }



        public bool AgregarCliente(Cliente cli)
        {
            if (String.IsNullOrWhiteSpace(cli.documento))
            {
                throw new DatException("Hay datos faltantes");
            }           
            if (BuscarClientePorDocumento(cli.documento) == null)
            {
                 colClientes.Add(cli);
                 return true;
            }
            return false;           
        }     


        public Cliente BuscarClientePorDocumento(string xDocumento)
        {
            foreach (Cliente cli in colClientes)
            {
                if (cli.documento == xDocumento)
                {
                    return cli;
                }                    
            }
            return null;            
        }


        public ClienteParticular BuscarClienteParticularPorDocumento(string Documento)
        {
            foreach (ClienteParticular cli in colClientes)
            {
                if (cli.documento == Documento)
                {
                    return cli;
                }
            }
            return null;
        }

        public ClienteEmpresa BuscarClienteEmpresaPorDocumento(string Documento)
        {
            foreach (ClienteEmpresa cli in colClientes)
            {
                if (cli.documento == Documento)
                {
                    return cli;
                }
            }
            return null;
        }

        public bool EliminarCliente(string xDocumento)
        {
            foreach (Cliente cli in colClientes)
            {
                if (cli.documento == xDocumento)
                {
                    colClientes.Remove(cli);
                    return true;
                }
            }
            return false;
        }

         public void ModificarClienteParticular(string xDocumento, string xpaisDocumento, string xTelefono)
        {
            ClienteParticular cliP = BuscarClienteParticularPorDocumento(xDocumento);
            cliP.paisDocumento = xpaisDocumento;     
            cliP.telefono = xTelefono;        
        }

        public void ModificarClienteEmpresa(string xDocumento, string xRazonSocial, string xTel, string xNomPerContacto)
        {
            ClienteEmpresa cliE = BuscarClienteEmpresaPorDocumento(xDocumento);
            cliE.razonSocial = xRazonSocial;
            cliE.tel = xTel;
            cliE.nomPerContacto = xNomPerContacto;
        }

          

    }
}
