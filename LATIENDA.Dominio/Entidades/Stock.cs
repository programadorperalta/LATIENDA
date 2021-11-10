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
        private int _cantidad;
        private Producto _producto;
        private Color _color;
        private Talle _talle;
        #endregion

        #region Constructores
        public Stock()
        {

        }

        public Stock(int cantidad,Producto producto,Color color, Talle talle)
        {
            Cantidad = cantidad;
            Producto = producto;
            Color = color;
            Talle = talle;
        }
        #endregion


        #region Propiedades
        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }
        public Producto Producto { get { return _producto; } set { _producto = value; } }
        public Color Color { get { return _color; } set { _color = value; } }
        public Talle Talle { get { return _talle; } set { _talle = value; } }
        #endregion

    }
}
