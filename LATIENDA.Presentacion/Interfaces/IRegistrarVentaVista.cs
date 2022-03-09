using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Presentacion.Interfaces
{
    public interface IRegistrarVentaVista : IVista
    {
        void RecibirStock(Stock stock);
        void RecibirCliente(Cliente cliente);
        void RecibirVenta(Venta venta);
        void RecibirPago(Pago pago);
        void MostrarMensaje(string descripcion, Mensaje tipo);
        void RecibirLineaDeVenta(LineadeVenta lineadeVenta);
        void CargarTabladeProductos(LineadeVenta lineadeVenta);
        void MostrarTotal(double total);
        void MostrarTiposdePago(List<TipodePago> tiposdepagos);

    }
}
