using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class LineadeVenta
    {
        #region Propiedades 
        public int ID { get; set; }
        public int Numero { get; set; }
        public int Cantidad { get; set; }
        public virtual Stock Stock { get; set; }
        public double Subtotal { get { return Cantidad * Stock.Producto.PreciodeVenta; } set { } }
        #endregion

        #region Constructores 
        public LineadeVenta() 
        {
        }
        #endregion


    }
}
