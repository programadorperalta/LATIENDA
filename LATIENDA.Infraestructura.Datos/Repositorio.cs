using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;


namespace LATIENDA.Infraestructura.Datos
{
    public class Repositorio : IRepositorio
    {
        private ProductoContext _context;
       

        public Repositorio()
        {
            _context = new ProductoContext();
           
        }

        #region Producto
        public void AgregarProducto(Producto nuevoProducto)
        {
            _context.Productos.Add(nuevoProducto);
            _context.SaveChanges();
        }

        public Producto BuscarProducto(int codigo)
        {
            return _context.Productos.ToList().Find(x => x.Codigo == codigo);
        }

        public void EliminarProducto(int codigo)
        {
            _context.Productos.Remove(_context.Productos.SingleOrDefault(p => p.Codigo == codigo));
            _context.SaveChanges();
        }

        public void ModificarProducto(int codigoActual, Producto productoModificado)
        {

            if (codigoActual != productoModificado.Codigo && YaExiste(productoModificado.Codigo)) throw new Exception("Ya existe un producto con este codigo.");
            var producto = from prod in _context.Productos where prod.Codigo == productoModificado.Codigo select prod;

            foreach (Producto prod in producto)
            {
                prod.Codigo = productoModificado.Codigo;
                prod.Costo = productoModificado.Costo;
                prod.CostoConIva = productoModificado.CostoConIva;
                prod.Descripcion = productoModificado.Descripcion;
                prod.Marca = productoModificado.Marca;
                prod.MargendeGanancia = productoModificado.MargendeGanancia;
                prod.NetoGravado = productoModificado.NetoGravado;
                prod.PorcentajeIva = productoModificado.PorcentajeIva;
                prod.PreciodeVenta = productoModificado.PreciodeVenta;
                prod.Rubro = productoModificado.Rubro;
                prod.TipodeTalle = productoModificado.TipodeTalle;
            }

            _context.SaveChanges();
        }

        #endregion

        #region Filtros
        public List<Producto> FiltrarLista(string terminoBusqueda)
        {
            return _context.Productos.ToList().FindAll(x => x.Descripcion.ToLower().Contains(terminoBusqueda?.ToLower()));
        }

        public List<Talle> FiltrarListadeTalles(int tipodetalle)
        {
            return _context.Talles.ToList().FindAll(x => x.TipodeTalle.ID == tipodetalle);
        }

        #endregion

        #region Validaciones
        private bool YaExiste(int codigoConsulta)
        {
            return _context.Productos.ToList().Exists(x => x.Codigo == codigoConsulta);
        }
        #endregion

        #region GetListas
        public List<Producto> ObtenerListaProductos()
        {
            return _context.Productos.ToList();
        }

        public List<Rubro> ObtenerListaRubros()
        {
            return _context.Rubros.ToList();
        }

        public List<Marca> ObtenerListaMarcas()
        {
            return _context.Marcas.ToList();
        }

        public List<Talle> ObtenerListaTalles()
        {
            return _context.Talles.ToList();
        }

        public List<Color> ObtenerListaColores()
        {
            return _context.Colores.ToList();
        }

        public List<TipodeTalle> ObtenerListaDeTiposdeTalles()
        {
            return _context.TipodeTalles.ToList();
        }
        
        #endregion

        #region Usuario 
        public bool ValidarUsuario(Usuario usuario)
        {
            if (_context.Usuarios.ToList().Exists(u => u.NombredeUsuario.Equals(usuario.NombredeUsuario) && u.Clave.Equals(usuario.Clave)))
            {
                return true;
            }
            return false;
        }

        public Usuario BuscarUsuario(Usuario usuarioABuscar)
        {
            return _context.Usuarios.ToList().Find(u => u.NombredeUsuario.Equals(usuarioABuscar.NombredeUsuario) && u.Clave.Equals(usuarioABuscar.Clave));
        }

        #endregion

        #region Stock
        public void AgregarStock(Stock stock)
        {
            _context.Stocks.Add(stock);
            _context.SaveChanges();
        }

        public Stock BuscarStock(int codigo)
        {
            return _context.Stocks.ToList().Find(x=>x.Producto.Codigo == codigo);
        }

        #endregion

        #region Cliente
        public void AgregarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public Cliente BuscarCliente(long cuitoDNI)
        {
            return _context.Clientes.ToList().Find(c => c.Cuit == cuitoDNI);
        }

        public List<Cliente> ObtenerListadeClientes()
        {
            return _context.Clientes.ToList();
        }

        public void EliminarCliente(long cuit)
        {
            _context.Clientes.Remove(_context.Clientes.SingleOrDefault(c => c.Cuit == cuit));
            _context.SaveChanges();
        }

        #endregion

        #region Venta
        public void AgregarVenta(Venta venta)
        {
            _context.Ventas.Add(venta);
            _context.SaveChanges();
        }

        public Venta BuscarVenta(int codigo)
        {
            return _context.Ventas.ToList().Find(x=>x.Numero == codigo);
        }

        public List<Venta> ObtenerListadeVentas()
        {
            return _context.Ventas.ToList();
        }

        public void EliminarVenta(int codigo)
        {
            _context.Ventas.Remove(_context.Ventas.SingleOrDefault(x=>x.Numero == codigo));
            _context.SaveChanges();
        }

        #endregion

        #region TipodePago

        public List<TipodePago> ObtenerListadeTiposdePagos()
        {
            return _context.TipodePagos.ToList();
        }

        #endregion
    }
}
