using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{
    public class Stock
    {
        #region Propiedades 
        public int ID { get; set; }
        public virtual int Cantidad { get; set; }
        public virtual Color Color { get; set; }
        public virtual Talle Talle { get; set; }
        public virtual Producto Producto { get; set; }
        #endregion

    }
}
