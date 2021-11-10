using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class PuntodeVenta
    {
        #region Atributos 
        private int _numero;
        private Venta _venta;
        #endregion


        #region Constructores
        public PuntodeVenta(int numero)
        {
            Numero = numero;
        }

        public PuntodeVenta(PuntodeVenta aCopiar)
        {
            Numero = aCopiar.Numero;
            Venta = new Venta();
        }
        #endregion


        #region Propiedades
        public Venta Venta { get { return _venta; } set { _venta = value; } }

        public int Numero { get { return _numero; } set { _numero = value; } }
        #endregion


    }
}
