using System;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Datos;
using LATIENDA.Presentacion.Tareas;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LATIENDA.Presentacion.Presentadores
{
    public class AgregarProductoPresentador :  PresentadorBase<ProductoTarea, IAgregarProductoVista,ISesion>
    {
        Producto _productoSource;
        private readonly IRepositorio _repositorio;

        public AgregarProductoPresentador(IAgregarProductoVista vista, 
            IRepositorio repositorio,ISesion sesion) : base(vista,sesion)
        {
            _repositorio = repositorio;
            CrearProductoSource();
            MostrarRubros();
            MostrarMarcas();
            MostrarTiposdeTalles();
           
        }
        
        public void CrearProductoSource()
        {
            _productoSource = null;
            _productoSource = new Producto();
            Vista.RecibirProducto(_productoSource);
            
        }

        public void MostrarTiposdeTalles()
        {
            Vista.MostrarTiposdeTalles(_repositorio.ObtenerListaDeTiposdeTalles());
        }

        public  void MostrarRubros()
        {
            Vista.MostrarRubros(_repositorio.ObtenerListaRubros());
        }

        public void MostrarMarcas()
        {
            Vista.MostrarMarcas(_repositorio.ObtenerListaMarcas());
        }

        public void AgregarProductos(Producto producto)
        {
            try
            {
                _productoSource.Marca = producto.Marca;
                _productoSource.Rubro = producto.Rubro;
                _productoSource.TipodeTalle = producto.TipodeTalle;

                _repositorio.AgregarProducto(_productoSource);
                Vista.MostrarMensaje("Producto agregado con exito.", Mensaje.EXITO);
                //Vista.ActualizarTabla(_repositorio.ObtenerListaProductos());                   
                CrearProductoSource();
            }
            catch (FormatException formatoExcepcion)
            {
                Vista.MostrarMensaje(formatoExcepcion.Message, Mensaje.ERROR);
            }
            catch (Exception excepcionExistencia)
            {
                Vista.MostrarMensaje(excepcionExistencia.Message, Mensaje.ERROR);
            }
        }
    }
}
