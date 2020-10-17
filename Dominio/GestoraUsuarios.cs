using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class GestoraUsuarios
    {
        private List<Usuario> colUsuarios;
        private static GestoraUsuarios instanciaGestora = null;

        public GestoraUsuarios()
        {
            colUsuarios = new List<Usuario>();
            CargarUsuariosPorDefecto();
        }

        public static GestoraUsuarios Instancia
        {
            get
            {
                if (instanciaGestora == null)
                {
                    instanciaGestora = new GestoraUsuarios();
                }
                return instanciaGestora;
            }
        }

        private void CargarUsuariosPorDefecto()
        {
            Usuario u1 = new Vendedor();
            u1.NombreUsuario = "vendedor1";
            u1.Clave = "vendedor1";
            colUsuarios.Add(u1);
            Usuario u2 = new Administrador();
            u2.NombreUsuario = "administrador1";
            u2.Clave = "administrador1";
            colUsuarios.Add(u2);           
        }

        public Usuario BuscarUsuario(String xNombreUsuario, String xClave)
        {
            foreach (Usuario u in colUsuarios)
            {
                if (u.NombreUsuario.Equals(xNombreUsuario) && u.Clave.Equals(xClave))
                {
                    return u;
                }
            }
            return null;
        }
    }
}
