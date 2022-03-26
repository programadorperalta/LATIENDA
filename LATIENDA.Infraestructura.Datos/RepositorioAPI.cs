using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Infraestructura.Cliente.AccesoExterno;

namespace LATIENDA.Infraestructura.Datos
{
    public class RepositorioAPI : IRepositorio
    {
        public void AgregarCliente(Dominio.Entidades.Cliente cliente)
        {
            AdapterAPI.Post("api/Clientes", cliente);
        }

        public void AgregarProducto(Producto nuevoProducto)
        {
           AdapterAPI.Post("api/Productos", nuevoProducto);
        }

        public void AgregarStock(Stock stock)
        {
            AdapterAPI.Post("api/Stocks",stock);
        }

        public void AgregarVenta(Venta venta)
        {
            AdapterAPI.Post("api/Venta", venta);
        }

        public Dominio.Entidades.Cliente BuscarCliente(long cuitoDNI)
        {
            return AdapterAPI.GetList<Dominio.Entidades.Cliente>("api/Clientes").Find(c => c.Cuit == cuitoDNI);
        }

        public Producto BuscarProducto(int codigo)
        {
            return AdapterAPI.GetList<Producto>("api/Productos").Find(p=>p.Codigo==codigo);
        }

        public Stock BuscarStock(int codigo)
        {
            return AdapterAPI.Get<Stock>("api/Stocks/{}"); // PREGUNTAR
        }

       public Empleado BuscarEmpleado(int codigo)
       {
            return AdapterAPI.Get<Empleado>($"api/Empleados/{codigo}");
       }

        public Venta BuscarVenta(int codigo)
        {
            return AdapterAPI.GetList<Venta>($"api/Ventas").Find(v => v.Numero == codigo); 
        }

        public void EliminarCliente(long cuit)
        {
            throw new NotImplementedException();
        }

        public void EliminarProducto(int codigo)
        {
            AdapterAPI.Delete($"api/Productos/{codigo}");
        }

        public void EliminarVenta(int codigo)
        {
            throw new NotImplementedException();
        }

        public List<Producto> FiltrarLista(string terminoBusqueda)
        {
            return AdapterAPI.GetList<Producto>("api/Productos").FindAll(x => x.Descripcion.ToLower().Contains(terminoBusqueda?.ToLower()));
        }

        public List<Talle> FiltrarListadeTalles(int tipodetalle)
        {
            throw new NotImplementedException();
        }

        public void ModificarProducto(Producto productoModificado)
        {
            AdapterAPI.Put($"api/Productos/{productoModificado.ID}",productoModificado);
        }

        public List<Color> ObtenerListaColores()
        {
            return AdapterAPI.GetList<Color>("api/Colores");
        }

        public List<Dominio.Entidades.Cliente> ObtenerListadeClientes()
        {
            return AdapterAPI.GetList<Dominio.Entidades.Cliente>("api/Clientes");
        }

        public List<TipodePago> ObtenerListadeTiposdePagos()
        {
            return AdapterAPI.GetList<TipodePago>("api/TiposdePagos");
        }

        public List<TipodeTalle> ObtenerListaDeTiposdeTalles()
        {
            return AdapterAPI.GetList<TipodeTalle>("api/TipodeTalles");
        }

        public List<Venta> ObtenerListadeVentas()
        {
            return AdapterAPI.GetList<Venta>("api/Ventas");
        }

        public List<Marca> ObtenerListaMarcas()
        {
            return AdapterAPI.GetList<Marca>("api/Marcas");
        }

        public List<Producto> ObtenerListaProductos()
        {
            return AdapterAPI.GetList<Producto>("api/Productos");
        }

        public List<Rubro> ObtenerListaRubros()
        {
            return AdapterAPI.GetList<Rubro>("api/Rubros");
        }

        public List<Talle> ObtenerListaTalles()
        {
            return AdapterAPI.GetList<Talle>("api/Talles");
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            if (AdapterAPI.Get<Usuario>($"api/Usuarios/{usuario.ID}")!=null)
            {
                return true;
            }
            return false;
        }

        public Usuario BuscarUsuario(Usuario usuarioABuscar)
        {
            return AdapterAPI.GetList<Usuario>("api/Usuarios").ToList().Find(u => u.NombredeUsuario.Equals(usuarioABuscar.NombredeUsuario) && u.Clave.Equals(usuarioABuscar.Clave));
        }
    }
}
