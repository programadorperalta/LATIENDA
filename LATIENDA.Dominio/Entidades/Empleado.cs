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
        private int _legajo;
        private string _nombre;
        private RolEmpleado _rolempleado;
        private TipodeSucursal _tipodeSucursal;
        #endregion


        #region Constructores
        public Empleado()
        {

        }
        public Empleado(int legajo,string nombre,RolEmpleado rol,TipodeSucursal tipodeSucursal)
        {
            Legajo = legajo;
            Nombre = nombre;
            RolEmpleado = rol;
            TipodeSucursal = tipodeSucursal;
        }
        #endregion

        #region Propiedades
        public TipodeSucursal TipodeSucursal { get { return _tipodeSucursal; } set { _tipodeSucursal = value; } }
        public int EmpleadoID { get; set; }
        public int Legajo { get { return _legajo; } set { _legajo = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public virtual RolEmpleado RolEmpleado { get { return _rolempleado; } set { _rolempleado = value; } }
        #endregion


    }
}
