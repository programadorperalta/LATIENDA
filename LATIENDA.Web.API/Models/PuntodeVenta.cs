using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{
    public class PuntodeVenta
    {
        #region Propiedades
        public int ID { get; set; }
        public int Numero { get; set; }
        public Venta Venta { get; set; }
        #endregion

    }
}
