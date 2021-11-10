using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Comprobante
    {
        #region Atributos 
        private int _numerocomprobante;
        private TipodeComprobante _tipodeComprobante;
        private Venta _venta;
        private PuntodeVenta _puntodeVenta;
        #endregion

        #region Constructores
        public Comprobante()
        {
            
        }
        public Comprobante(int numeroComprobante, TipodeComprobante tipoComprobante, Venta venta, PuntodeVenta puntodeventa)
        {
            NumerodeComprobante = numeroComprobante;
            TipodeComprobante = tipoComprobante;
            Venta = venta;
            PuntodeVenta = puntodeventa;
        }
        #endregion

        #region Propiedades
        public int NumerodeComprobante { get { return _numerocomprobante; } set { _numerocomprobante = value; } }
        public TipodeComprobante TipodeComprobante { get { return _tipodeComprobante; } set { _tipodeComprobante = value; } } 
        public Venta Venta { get { return _venta; } set { _venta = value; } }
        public PuntodeVenta PuntodeVenta { get { return _puntodeVenta; }set { _puntodeVenta = value; } }

        #endregion



    }
}
