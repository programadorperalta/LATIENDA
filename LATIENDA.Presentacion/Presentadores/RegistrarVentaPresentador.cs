using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Cliente.AccesoExterno;
using LATIENDA.Infraestructura.Transversal;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LATIENDA.Presentacion.Presentadores
{
    public class RegistrarVentaPresentador : PresentadorBase<VentaTarea, IRegistrarVentaVista,ISesion>
    {
        private IRepositorio _repositorio;
        Cliente _clienteSource;
        Venta _ventaSource;
        double acumulador = 0;

        public RegistrarVentaPresentador(IRegistrarVentaVista vista,IRepositorio repositorio,ISesion sesion) : base(vista,sesion)
        {
            _repositorio = repositorio;
            InitCreate();
            
        }

        public void InitCreate()
        {
            CrearVentaSource();
            CargarLineadeVentaSource();
            CrearPagoSource();
            MostrarTiposdePagos();
        }

        public void CrearVentaSource()
        {
            _ventaSource = null;
            _ventaSource = new Venta();
            Vista.RecibirVenta(_ventaSource);
        }

        public void CrearPagoSource()
        {
            Vista.RecibirPago(_ventaSource.Pago);
        }

        public void CargarVenta()
        {
            _ventaSource.Cliente = _clienteSource;
            _ventaSource.Usuario = Sesion.GetUsuario();
        }


        public void GenerarComprobante()
        {
            CargarVenta(); 
            Tarea.Venta = _ventaSource;
            Tarea.NavegarA<ComprobantePresentador>(esDialogo: true, esMdiHijo: true);
        }


        public void MostrarTiposdePagos()
        {
            Vista.MostrarTiposdePago(_repositorio.ObtenerListadeTiposdePagos());
        }


        public void BuscarCliente(long cuit)
        {
            _clienteSource = _repositorio.BuscarCliente(cuit);

            if (_clienteSource !=null)
            {
                    Vista.RecibirCliente(_clienteSource);
                    Vista.MostrarMensaje("Cliente encontrado con exito", Mensaje.EXITO);
            } else
            {
                Vista.MostrarMensaje("No se encontro el cliente",Mensaje.ERROR);
            }

        }

        public void CargarLineadeVentaSource()
        {
            Vista.RecibirLineaDeVenta(_ventaSource.LineadeVenta);
        }

        public void CalcularTotal()
        {
            acumulador += _ventaSource.LineadeVenta.Subtotal;
            Vista.MostrarTotal(acumulador);
            CargarLineadeVentaSource();
        }

        public void CargarTabladeLineaDeVenta()
        {
            Vista.CargarTabladeProductos(_ventaSource.LineadeVenta);
        }

        public void BuscarStockdeProducto(int codigo)
        {
            _ventaSource.LineadeVenta.Stock = _repositorio.BuscarStock(codigo);

            if (_ventaSource.LineadeVenta.Stock != null)
            {
                Vista.RecibirStock(_ventaSource.LineadeVenta.Stock);
                _ventaSource.AgregarLineaDeVentaAlaLista();

                Vista.MostrarMensaje("Producto Encontrado con exito!",Mensaje.EXITO);

            }
            else
            {
                Vista.MostrarMensaje("No se encontro el producto, Intente nuevamente",Mensaje.EXITO);
            }



        }




    }
}
