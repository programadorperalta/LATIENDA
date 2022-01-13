using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;

namespace LATIENDA.Infraestructura.Datos
{

    public class Inventario : IRepositorio
    {
        private List<Producto> _inventario = new List<Producto>();
        private List<Stock> _stocks = new List<Stock>();
        private List<Talle> _talles = new List<Talle>();
        private List<Venta> _ventas = new List<Venta>();

        public void AgregarProducto(Producto nuevoProducto)
        {
            throw new NotImplementedException();
        }

        //public void AgregarProducto(Producto nuevoProducto)
        //{        
        //    if (YaExiste(nuevoProducto.Codigo)) throw new Exception("Ya existe un producto con este codigo.");
        //    _inventario.Add(nuevoProducto);
        //}

        public Producto BuscarProducto(int codigo)
        {
            throw new NotImplementedException();
        }

        public void EliminarProducto(int codigo)
        {
            throw new NotImplementedException();
        }

        public List<Producto> FiltrarLista(string terminoBusqueda)
        {
            throw new NotImplementedException();
        }

        public void ModificarProducto(int codigoActual, Producto productoModificado)
        {
            throw new NotImplementedException();
        }

        public List<Marca> ObtenerListaMarcas()
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerListaProductos()
        {
            throw new NotImplementedException();
        }

        public List<Rubro> ObtenerListaRubros()
        {
            throw new NotImplementedException();
        }

        public bool ValidarUsuario(string usuario, string contraseña)
        {
            throw new NotImplementedException();
        }



        //public void CargarStock()
        //{

        //    _stocks.Add
        //        (
        //        new Stock(30, 
        //        new Producto(2, "Remera", 21, 20, 80, 23, 45, 21, new Rubro(1, "Ropa depotiva"), new Marca(1, "Adidas")), 
        //        new Color(1, "AZUL"),
        //        new Talle("XS", new TipodeTalle("LATINOAMERICANO")))
        //        //la otra opcion es que stock este relacionado con
        //        //EspecificaciondeTalle que contenga Talle ejemplo: Ropa --> XS,S.... , Calzados ----> 25...41
        //        //(EspecificaciondeTalle (List<Talle> talles))

        //        ); ;

        //    _stocks.Add
        //        (
        //        new Stock(60,
        //        new Producto(),
        //        new Color(),
        //        new Talle()
        //        )

        //        ) ;




        //}

        ///*public Venta(int numero, double monto, Usuario usuario,
        // * List<Producto> productos,Cliente cliente,
        // * int cantidad,LineadeVenta lineadeVenta)
        //{*/

        //public void CrearVenta()
        //{
        //    _ventas.Add

        //        (

        //        new Venta(1,25,new Usuario(),new List<Producto>(),new Cliente(),25,new LineadeVenta())

        //        );

        //}

        //public void EliminarProducto(int codigo)
        //{
        //    if(YaExiste(codigo))
        //    {
        //        int indiceEliminar = _inventario.FindIndex(x => x.Codigo == codigo);
        //        _inventario.RemoveAt(indiceEliminar);
        //    }
        //}

        //public Producto BuscarProducto(int codigo)
        //{
        //    return _inventario.Find(x => x.Codigo == codigo);
        //}

        //public void ModificarProducto(int codigoActual, Producto productoModificado)
        //{
        //    if (codigoActual != productoModificado.Codigo && YaExiste(productoModificado.Codigo)) throw new Exception("Ya existe un producto con este codigo.");
        //    int indiceModificar = _inventario.FindIndex(x => x.Codigo == codigoActual);
        //    _inventario[indiceModificar] = productoModificado;
        //}

        //private bool YaExiste(int codigoConsulta)
        //{
        //    return _inventario.Exists(x => x.Codigo == codigoConsulta);
        //}

        //public List<Producto> ObtenerListaProductos()
        //{
        //    return _inventario;
        //}

        //public List<Producto> FiltrarLista(string terminoBusqueda)
        //{
        //    return _inventario.FindAll(x => x.Descripcion.ToLower().Contains(terminoBusqueda?.ToLower()));
        //}

        //public List<Rubro> ObtenerListaRubros()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Marca> ObtenerListaMarcas()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool ValidarUsuario(string usuario,string contraseña)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
