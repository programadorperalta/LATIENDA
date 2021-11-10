using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class LineadeVenta
    {
        #region Atributos 
        private int _numero;
        private Producto _producto;
        private int _cantidad;
        private double _subtotal;
        #endregion

        #region Constructores 
        //La linea de venta tiene venta o tiene productos?
        public LineadeVenta() { }

        public LineadeVenta(int numero,Producto producto,int cantidad)
        {
            Numero = numero;
            Producto = producto;
            Cantidad = cantidad;

        }

        #endregion

        #region Propiedades
        public int Numero { get { return _numero ; } set {_numero = value; } }
        public Producto Producto { get { return _producto; } set { _producto = value; } }
        public int Cantidad { get { return _cantidad; }set { _cantidad = value; } }
        //public double Subtotal { get { return _subtotal = _producto.PreciodeVenta * _cantidad; }set { _subtotal = value; } }
        #endregion

        public double CalcularSubtotal()
        {
            return _subtotal = _producto.PreciodeVenta * _cantidad;
        }



    }
}
