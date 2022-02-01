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
        void EliminarProducto(int codigo);
        List<Producto> FiltrarLista(string terminoBusqueda);
        void ModificarProducto(int codigoActual, Producto productoModificado);
        List<Producto> ObtenerListaProductos();
        List<Rubro> ObtenerListaRubros();
        List<Marca> ObtenerListaMarcas();
        List<Talle> ObtenerListaTalles();
        List<Color> ObtenerListaColores();
        List<TipodeTalle> ObtenerListaDeTiposdeTalles();
        List<Talle> FiltrarListadeTalles(int tipodetalle);
        void AgregarStock(Stock stock);
        bool ValidarUsuario(string usuario,string contraseña);


    }
}
