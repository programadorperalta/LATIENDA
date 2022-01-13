using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Usuario
    {
        #region Atributos
        public int ID { get; set; }
        private string _nombredeusuario;
        private string _clave;
        private RolUsuario _rolusuario;
        private Empleado _empleado;
        #endregion

        #region Constructores

        public Usuario()
        {

        }


        public Usuario(string nombredeusuario,string clave) // constructor para busqueda 
        {
            NombredeUsuario = nombredeusuario;
            Clave = clave;
        }


        public Usuario(string nombre, string clave, RolUsuario rolusuario, Empleado empleado)
        {
            NombredeUsuario = nombre;
            Clave = clave;
            RolUsuario = rolusuario;
            Empleado = empleado;
        }
        #endregion


        #region Propiedades
        public int UserID { get; set; }
        public string NombredeUsuario { get { return _nombredeusuario; } set { _nombredeusuario = value; } }
        public string Clave { get  {  return _clave;  }  set  { _clave = value;  } }
        public virtual RolUsuario RolUsuario { get { return _rolusuario; }  set { _rolusuario = value;  }  }
        public virtual Empleado Empleado { get { return _empleado; } set { _empleado = value;  } }
        #endregion
    }
}
