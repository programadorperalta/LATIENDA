using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Cliente.AccesoExterno;
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
    public class ComprobantePresentador : PresentadorBase<VentaTarea, IComprobanteVista, ISesion>
    {

        private readonly IRepositorio _repositorio;
        private Comprobante _comprobanteSource;

        public override VentaTarea Tarea
        {
            get => base.Tarea;
            set
            {
                base.Tarea = value;
                CargarComprobante();
            }
        }

        public ComprobantePresentador(IComprobanteVista vista,
            IRepositorio repositorio, ISesion sesion) : base(vista, sesion)
        {
            _repositorio = repositorio;
            
        }


        public void CargarComprobante()
        {
            _comprobanteSource = null;
            _comprobanteSource = ReglasDeNegocio.DeterminarComprobante(Tarea.Venta.Cliente);
            _comprobanteSource.Numero = 1;
            _comprobanteSource.Venta= Tarea.Venta;
            Vista.RecibirComprobante(_comprobanteSource);

        }

        public void ConexionServicioExterno()
        {
            MessageBox.Show($"Tipo de Comprobante a emitir: {_comprobanteSource.TipodeComprobante}");

            var adaptador = Adaptador.ObtenerAutorizacion();

            if (adaptador != null)
            {
                var response = Adaptador.ObtenerCAEResponse(adaptador,_comprobanteSource);

                if (response.FeCabResp.Resultado.Equals("A"))
                {
                    MessageBox.Show("Se ha aprobado el comprobante con exito");
                }
                else
                {
                    MessageBox.Show("No se ha aprobado el comprobante");
                }



            }

        }







    }
}
