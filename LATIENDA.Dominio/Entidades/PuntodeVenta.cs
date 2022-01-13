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
        public int ID { get; set; }
        private int _numero;
        private Venta _venta;
        #endregion


        #region Constructores
        public PuntodeVenta(int numero)
        {
            Numero = numero;
        }

        #endregion


        #region Propiedades
        public Venta Venta { get { return _venta; } set { _venta = value; } }

        public int Numero { get { return _numero; } set { _numero = value; } }
        #endregion


    }
}
