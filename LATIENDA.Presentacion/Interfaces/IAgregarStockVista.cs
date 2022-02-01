using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Presentacion.Interfaces
{
    public interface IAgregarStockVista : IVista
    {
        void RecibirStock(Stock stock);
        void MostrarTalles(List<Talle> talles);
        void MostrarColores(List<Color> colores);
        void BuscarProducto(int codigo);
        void RecibirProducto(Producto producto);
        void MostrarMensaje(string descripcion,Mensaje tipo);
      


    }
}
