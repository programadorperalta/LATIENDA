using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Empleado
    {
        #region Atributos
        public int ID { get; set; }
        private int _legajo;
        private string _nombre;
        private RolEmpleado _rolempleado;
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

        #region Propiedades
        public int Legajo { get { return _legajo; } set { _legajo = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public virtual RolEmpleado RolEmpleado { get { return _rolempleado; } set { _rolempleado = value; } }
        #endregion


    }
}
