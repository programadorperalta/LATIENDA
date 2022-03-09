using LATIENDA.Web.API.Models.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{
    public class Comprobante
    {
        #region Propiedades 
        public int ID { get; set; }
        public int Numero { get; set; }
        public TipodeComprobante TipodeComprobante { get; set; }
        public virtual Venta Venta { get; set; }
        public virtual PuntodeVenta PuntodeVenta { get; set; }
        public string Fecha { get; set; }
        #endregion

    }
}
