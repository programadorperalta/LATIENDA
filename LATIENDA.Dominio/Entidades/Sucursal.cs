using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Sucursal : Tienda
    {
        #region Atributos
        private int _numero;
        private PuntodeVenta _puntodeventa; // puede tener mas de un punto de venta 
        private Stock _stock;
        private Empleado _empleado;
        #endregion

        public Sucursal()
        {

        }

        public Sucursal(int numero, PuntodeVenta puntodeVenta, Stock stock, Empleado empleado)
        {
            Numero = numero;
            PuntodeVenta = puntodeVenta;
            Stock = stock;
            Empleado = empleado;

        }


        #region Propiedades

        public int Numero { get { return _numero; } set { _numero = value; } }

        public PuntodeVenta PuntodeVenta
        {
            get { return _puntodeventa; }
            set { _puntodeventa = value; }
        }

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        #endregion

    }
}
