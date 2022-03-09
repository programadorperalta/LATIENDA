using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Infraestructura.Transversal
{
    public class Sesion : ISesion
    {
        #region Propiedades
        public Usuario Usuario { get; set; }
        public DateTime FechayHora { get; set; }
        #endregion

        public Sesion()
        {
            Usuario = new Usuario();
            FechayHora = DateTime.Now;
        }

        public void Conectar()
        {
            throw new NotImplementedException();
        }

        public void Desconectar()
        {
            throw new NotImplementedException();
        }

        public Usuario GetUsuario()
        {
            return Usuario;
        }

        public void EnviarUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }
    }
}
