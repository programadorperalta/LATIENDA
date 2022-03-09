using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{
    public class LineadeVenta
    {
        #region Propiedades 
        public int ID { get; set; }
        public int Numero { get; set; }
        public int Cantidad { get; set; }
        public virtual Stock Stock { get; set; }
        public double Subtotal { get; set; }
        #endregion

    }
}
