using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{
    public class Venta
    {
        #region Propiedades 
        public int ID { get; set; }
        public int Numero { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual DateTime FechayHora { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Pago Pago { get; set; }
        public virtual List<LineadeVenta> LineasdeVenta { get; set; }
        #endregion
    }
}
