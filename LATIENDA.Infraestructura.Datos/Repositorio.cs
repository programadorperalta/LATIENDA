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
            _context.Productos.Remove(_context.Productos.SingleOrDefault(p=> p.Codigo == codigo));
            _context.SaveChanges();
        }

        public List<Producto> FiltrarLista(string terminoBusqueda)
        {
            return _context.Productos.ToList().FindAll(x => x.Descripcion.ToLower().Contains(terminoBusqueda?.ToLower()));
        }

        public List<Talle> FiltrarListadeTalles(int tipodetalle)
        {
            return _context.Talles.ToList().FindAll(x=> x.TipodeTalle.ID == tipodetalle);
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

      


        private bool YaExiste(int codigoConsulta)
        {
            return _context.Productos.ToList().Exists(x => x.Codigo == codigoConsulta);
        }



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

        public bool ValidarUsuario(string usuario,string contraseña)
        {
            if (_context.Usuarios.ToList().Exists(u=> u.NombredeUsuario == usuario)){
                return true;
                
           }
            return false;
        }

        public void AgregarStock(Stock stock)
        {
            _context.Stocks.Add(stock);
            _context.SaveChanges();
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
    }
}
