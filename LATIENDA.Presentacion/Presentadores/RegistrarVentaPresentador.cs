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
        //Producto _productoSource;
        Venta _ventaSource;
        Stock _stockSource;
        LineadeVenta _lineadeVentaSource;
        List<LineadeVenta> _lineadeVentasTemporal = new List<LineadeVenta>();
        private Comprobante _comprobante = new Comprobante();
        Pago _pagoSource;
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
            _pagoSource = null;
            _pagoSource = new Pago();
            Vista.RecibirPago(_pagoSource);
        }

        public void CargarVenta()
        {
            _ventaSource.Cliente = _clienteSource;
            _ventaSource.Pago = _pagoSource;
            _ventaSource.LineasdeVenta = _lineadeVentasTemporal;
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
            _lineadeVentaSource = null;
            _lineadeVentaSource = new LineadeVenta();
            Vista.RecibirLineaDeVenta(_lineadeVentaSource);
        }

        public void CalcularTotal()
        {
            acumulador += _lineadeVentaSource.Subtotal;
            Vista.MostrarTotal(acumulador);
            CargarLineadeVentaSource();
        }

        public void AgregarStockALineadeVenta()
        {
            _lineadeVentaSource.Stock = _stockSource;
            _lineadeVentasTemporal.Add(_lineadeVentaSource);
            Vista.CargarTabladeProductos(_lineadeVentaSource);
        }

        public void BuscarStockdeProducto(int codigo)
        {
            _stockSource = _repositorio.BuscarStock(codigo);

            if (_stockSource!=null)
            {
                Vista.RecibirStock(_stockSource);
                Vista.MostrarMensaje("Producto Encontrado con exito!",Mensaje.EXITO);
            }
            else
            {
                Vista.MostrarMensaje("No se encontro el producto, Intente nuevamente",Mensaje.EXITO);
            }



        }




    }
}
