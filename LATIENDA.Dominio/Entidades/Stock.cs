using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Stock
    {
        #region Atributos 
        public int ID { get; set; }
        public virtual int Cantidad { get; set; }
        public virtual Color Color { get; set; }
        public virtual Talle Talle { get; set; }
        public virtual Producto Producto { get; set; }
        #endregion

        #region Constructores
        public Stock()
        {

        }

        public Stock(int cantidad,Color color, Talle talle)
        {
            Cantidad = cantidad;
            Color = color;
            Talle = talle;
        }
        #endregion



    }
}
