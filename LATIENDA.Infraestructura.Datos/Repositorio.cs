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
            _context.Productos.Remove(_context.Productos.SingleOrDefault(d => d.Codigo == codigo));
            _context.SaveChanges();
        }

        public List<Producto> FiltrarLista(string terminoBusqueda)
        {
           
            return _context.Productos.ToList().FindAll(x => x.Descripcion.ToLower().Contains(terminoBusqueda?.ToLower()));
        
        }

        public void ModificarProducto(int codigoActual, Producto productoModificado)
        {
            
            if (codigoActual != productoModificado.Codigo && YaExiste(productoModificado.Codigo)) throw new Exception("Ya existe un producto con este codigo.");
            AsignarProducto(productoModificado);

        }

        public void AsignarProducto(Producto productoModificado)
        {
            var producto = _context.Productos.First<Producto>();

            producto.Codigo = productoModificado.Codigo;
            producto.Descripcion = productoModificado.Descripcion;
            producto.MargendeGanancia = productoModificado.MargendeGanancia;
            producto.PorcentajeIva = productoModificado.PorcentajeIva;
            producto.Marca = productoModificado.Marca;
            producto.NetoGravado = productoModificado.NetoGravado;
            producto.PreciodeVenta = productoModificado.PreciodeVenta;
            producto.Rubro = productoModificado.Rubro;
            producto.Costo = productoModificado.Costo;
            producto.CostoConIva = productoModificado.CostoConIva;
            producto.Descripcion = productoModificado.Descripcion;

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

        public void AgregarStock()
        {

        }


    }
}
