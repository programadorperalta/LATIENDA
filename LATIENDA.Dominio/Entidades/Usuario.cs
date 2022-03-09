using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Usuario 
    {
        #region Atributos
        public int ID { get; set; }
        public string NombredeUsuario { get; set; }
        public string Clave { get; set; }
        public virtual RolUsuario Rolusuario { get; set; }
        public virtual Empleado Empleado { get; set; }
        public byte[] Imagen { get; set; }
        #endregion 

        #region Constructores

        public Usuario()
        {

        }
        #endregion
    }
}
