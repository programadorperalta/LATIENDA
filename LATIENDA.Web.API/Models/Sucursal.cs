using LATIENDA.Web.API.Models.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{
    public class Sucursal
    {
        #region Propiedades
        public int ID { get; set; }
        public int Numero { get; set; }
        public virtual PuntodeVenta PuntodeVenta { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual Empleado Empleado{get;set;}
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<PuntodeVenta> PuntosdeVenta { get; set; }
        public TipodeSucursal TipodeSucursal { get; set; }
        #endregion
    }
}
