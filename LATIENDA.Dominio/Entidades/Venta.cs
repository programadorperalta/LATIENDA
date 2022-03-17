using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Venta
    {
        #region Atributos 
        public int ID { get; set; }
        public int Numero { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual DateTime FechayHora { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Pago Pago { get; set; }
        public LineadeVenta LineadeVenta { get; set; }
        public virtual List<LineadeVenta> LineasdeVenta { get; set; }
        public virtual Comprobante Comprobante { get; set; }
        #endregion


        public Venta()
        {
            Pago = new Pago();
            LineadeVenta = new LineadeVenta();
            Comprobante = new Comprobante();
            FechayHora = DateTime.Now;
            LineasdeVenta = new List<LineadeVenta>();
        }


        public void AgregarLineaDeVentaAlaLista()
        {
            LineasdeVenta.Add(LineadeVenta);
        }


        public void DeterminarComprobante()
        {
           
            switch (Cliente.CondicionTributaria)
            {
                case CondicionTributaria.RI:

                    Comprobante.TipodeComprobante = TipodeComprobante.A;

                    break;

                case CondicionTributaria.M:

                    Comprobante.TipodeComprobante = TipodeComprobante.A;

                    break;


                default:

                    Comprobante.TipodeComprobante = TipodeComprobante.B;

                    break;

            }

        }



    }
}
