using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Empleado
    {
        #region Atributos
        public int ID { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public virtual RolEmpleado RolEmpleado { get; set; }
        public virtual IList<Usuario> Usuarios { get; set; }
        #endregion

        #region Constructores
        public Empleado()
        {

        }
        public Empleado(int legajo,string nombre,RolEmpleado rol)
        {
            Legajo = legajo;
            Nombre = nombre;
            RolEmpleado = rol;
        }
        #endregion

    }
}
