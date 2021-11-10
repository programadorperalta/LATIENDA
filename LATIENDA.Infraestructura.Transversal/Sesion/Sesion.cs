using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Infraestructura.Transversal.Sesion
{
    public class Sesion : ISesion
    {
        #region Atributos
        private Usuario _usuario;
        #endregion

        #region Constructores
        public Sesion(Usuario usuario)
        {
            Usuario = usuario;
        }
        #endregion

        #region Propiedades
        public Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public void Conectar()
        {
            throw new NotImplementedException();
        }

        public void Desconectar()
        {
            throw new NotImplementedException();
        }
        #endregion



    }
}
