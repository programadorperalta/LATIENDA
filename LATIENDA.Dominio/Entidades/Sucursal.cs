using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Sucursal
    {
        #region Atributos
        public int ID { get; set; }
        public int Numero { get; set; }
        public virtual PuntodeVenta PuntodeVenta { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual Empleado Empleado{get;set;}
        public virtual IList<Empleado> Empleados { get; set; }
        public virtual IList<Stock> Stocks { get; set; }
        public virtual IList<PuntodeVenta> PuntosdeVenta { get; set; }
        public virtual TipodeSucursal TipodeSucursal { get; set; }
        #endregion

        public Sucursal()
        {

        }
       
    }
}
