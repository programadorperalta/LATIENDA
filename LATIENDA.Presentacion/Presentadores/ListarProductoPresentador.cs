using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Vistas;
using LATIENDA.Dominio;
using LATIENDA.Infraestructura.Datos;
using LATIENDA.Presentacion.Tareas;

namespace LATIENDA.Presentacion.Presentadores
{
    public class ListarProductoPresentador: PresentadorBase<ProductoTarea, IListarProductosVista>
    {
        private readonly IRepositorio _repositorio;

        public ListarProductoPresentador(IListarProductosVista vista, 
            IRepositorio repositorio): base(vista)
        {
            _repositorio = repositorio;
            ActualizarInventario();
        }

        public void ActualizarInventario()
        {
            Vista.ActualizarTabla(_repositorio.ObtenerListaProductos());
        }

        public void FiltarInventario(string terminoBusqueda)
        {
            if (string.IsNullOrEmpty(terminoBusqueda))
            {
                ActualizarInventario();
            }
            else
            {
                Vista.ActualizarTabla(_repositorio.FiltrarLista(terminoBusqueda));
            }           
        }

        public void AgregarProducto()
        {
            Tarea.NavegarA<AgregarProductoPresentador>(esDialogo: true, esMdiHijo: true);
            ActualizarInventario();
        }

        public void ModificarProducto(int codigoModificar)
        {
            Tarea.ProductoId = codigoModificar;
            Tarea.NavegarA<ModificarProductoPresentador>(esDialogo: true, esMdiHijo: true);
            ActualizarInventario();
        }

        public void EliminarProducto(int codigo)
        {
            if (Vista.ConfirmarEliminacion())
            {
                _repositorio.EliminarProducto(codigo);
                Vista.MostrarMensaje("Producto eliminado con exito.", Mensaje.EXITO);
                ActualizarInventario();
            }
        }
    }
}
