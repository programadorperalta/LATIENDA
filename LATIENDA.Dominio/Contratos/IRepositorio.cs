using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;

namespace LATIENDA.Dominio
{
    public interface IRepositorio
    {
        void AgregarProducto(Producto nuevoProducto);
        Producto BuscarProducto(int codigo);
        Stock BuscarStock(int codigo);
        Usuario BuscarUsuario(Usuario usuarioABuscar);
        void EliminarProducto(int codigo);
        List<Producto> FiltrarLista(string terminoBusqueda);
        void ModificarProducto(Producto productoModificado);
        List<Producto> ObtenerListaProductos();
        List<Rubro> ObtenerListaRubros();
        List<Marca> ObtenerListaMarcas();
        List<Talle> ObtenerListaTalles();
        List<Color> ObtenerListaColores();
        List<TipodeTalle> ObtenerListaDeTiposdeTalles();
        List<Talle> FiltrarListadeTalles(int tipodetalle);

        List<TipodePago> ObtenerListadeTiposdePagos();
        void AgregarStock(Stock stock);
        bool ValidarUsuario(Usuario usuario);
        void AgregarCliente(Cliente cliente);
        Cliente BuscarCliente(long cuitoDNI);
        Empleado BuscarEmpleado(int codigo);
        List<Cliente> ObtenerListadeClientes();
        void EliminarCliente(long cuit);
        void AgregarVenta(Venta venta);
        Venta BuscarVenta(int codigo);
        List<Venta> ObtenerListadeVentas();
        void EliminarVenta(int codigo);
    }
}
