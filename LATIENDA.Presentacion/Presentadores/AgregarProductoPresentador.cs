using System;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Datos;
using LATIENDA.Presentacion.Tareas;
using System.Collections.Generic;

namespace LATIENDA.Presentacion.Presentadores
{
    public class AgregarProductoPresentador :  PresentadorBase<ProductoTarea, IAgregarProductoVista>
    {
        Producto _productoSource;
        IRepositorio _repositorio;

        public AgregarProductoPresentador(IAgregarProductoVista vista, 
            IRepositorio repositorio) : base(vista)
        {
            _repositorio = repositorio;
            CrearProductoSource();
            MostrarRubros();
            MostrarMarcas();
        }
        
        public void CrearProductoSource()
        {
            _productoSource = null;
            _productoSource = new Producto();
            Vista.RecibirProducto(_productoSource);
        }

        public  void MostrarRubros()
        {
            Vista.MostrarRubros(_repositorio.ObtenerListaRubros());
        }

        public void MostrarMarcas()
        {
            Vista.MostrarMarcas(_repositorio.ObtenerListaMarcas());
        }


        public void AgregarProductos()
        {
            try
            {

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
