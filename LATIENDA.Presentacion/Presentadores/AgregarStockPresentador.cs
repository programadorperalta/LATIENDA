using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Presentacion.Presentadores
{
    public class AgregarStockPresentador : PresentadorBase<ProductoTarea, IAgregarStockVista>
    {
        IRepositorio _repositorio;
        Producto _prod;
        Stock _stockSource;

        public AgregarStockPresentador (IAgregarStockVista vista,
            IRepositorio repositorio) : base(vista)
        {
            _repositorio = repositorio;
            CrearStockSource();
            MostrarTalles();
            MostrarColores();
        }

        public void CrearStockSource()
        {
            _stockSource = null;
            _stockSource = new Stock();
            Vista.RecibirStock(_stockSource);

        }

        public void AgregarStock(Stock stockAux)
        {
            _stockSource.Producto = _prod;
            _stockSource.Color = stockAux.Color;
            _stockSource.Talle = stockAux.Talle;

            _repositorio.AgregarStock(_stockSource);
            Vista.MostrarMensaje("Stock Agregado con exito!", Mensaje.EXITO);
        }

        public void FiltrarTalles(int tipodetalle)
        {
            if (tipodetalle!=0)
            {
                Vista.MostrarTalles(_repositorio.FiltrarListadeTalles(tipodetalle));
            }
        }


        public void BuscarProducto(int codigo)
        {
            _prod = null;
            _prod = _repositorio.BuscarProducto(codigo);

            if (_repositorio.BuscarProducto(codigo)!=null)
            {
                Vista.RecibirProducto(_prod);
                Vista.MostrarMensaje("Se encontro el producto con exito", Mensaje.EXITO);

            }
            else
            {
                Vista.MostrarMensaje("No se encontro el producto buscado.", Mensaje.ERROR);
            }
        }

        public void MostrarTalles()
        {
            Vista.MostrarTalles(_repositorio.ObtenerListaTalles());
        }

        public void MostrarColores()
        {
            Vista.MostrarColores(_repositorio.ObtenerListaColores());
        }

        public void BuscarProducto()
        {

        }





    }
}
