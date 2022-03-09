using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public static class ReglasDeNegocio
    {
        public static double IVA { get { return 0.21; } set { } }

        public static Comprobante DeterminarComprobante(Cliente cliente)
        {
            var comprobante = new Comprobante();

            switch (cliente.CondicionTributaria)
            {
                case CondicionTributaria.RI:

                     comprobante.TipodeComprobante = TipodeComprobante.A;

                    break;

                case CondicionTributaria.M:

                     comprobante.TipodeComprobante = TipodeComprobante.A;

                    break;


                default:

                    comprobante.TipodeComprobante = TipodeComprobante.B;

                    break;

            }

            return comprobante;

        }







    }
}
