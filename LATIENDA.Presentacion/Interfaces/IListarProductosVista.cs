using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;

namespace LATIENDA.Presentacion.Interfaces
{
    public interface IListarProductosVista: IVista
    {
        void ActualizarTabla(List<Producto> inventario);
        void MostrarMensaje(string descripcion, Mensaje tipo);
        bool ConfirmarEliminacion();
        
    }
}
