using LATIENDA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Presentacion.Interfaces
{
    public interface IComprobanteVista : IVista
    {
        void RecibirComprobante(Venta venta);

        void CargarCuerpoComprobante(Venta venta);

        //void CargarPieComprobante(Venta venta);
    }
}
