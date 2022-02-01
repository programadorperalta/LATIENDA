using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Dominio;

namespace LATIENDA.Presentacion.Interfaces
{
    public interface IAgregarProductoVista : IVista
    {
        void RecibirProducto(Producto producto);
        void MostrarMensaje(string descripcion, Mensaje tipo);
        void MostrarRubros(List<Rubro> rubros);
        void MostrarMarcas(List<Marca> marcas);
        void MostrarTiposdeTalles(List<TipodeTalle> tiposdetalles);
    }
}
