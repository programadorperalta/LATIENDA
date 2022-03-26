using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Cliente.AccesoExterno;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Tareas;

namespace LATIENDA.Presentacion.Presentadores
{
    public class PrincipalPresentador : PresentadorBase<PrincipalTarea, IPrincipalVista,ISesion>
    {
        private Tienda _tiendaSource;

        public override PrincipalTarea Tarea
        {
            get => base.Tarea;
            set
            {
                base.Tarea = value;
                MostrarUsuario();
            }
        }


        public PrincipalPresentador(IPrincipalVista vista,ISesion sesion) : base(vista,sesion)
        {
            ObtenerCredenciales();
        }

        public void ObtenerCredenciales()
        {

            _tiendaSource = null;
            _tiendaSource = new Tienda();

            //Vista.MostrarMensaje("Obteniendo Credenciales espere....",Mensaje.ADVERTENCIA);
            var adaptador = Adaptador.ObtenerAutorizacion();
            Vista.MostrarMensaje("Credenciales Obtenidas con exito!",Mensaje.EXITO);

            _tiendaSource.Cuit = adaptador.Cuit;

            Vista.RecibirTienda(_tiendaSource);
        }

        public void MostrarUsuario()
        {
            Vista.MostrarUsuario(Tarea.Sesion);
        }


        public void IniciarProductos()
        {
            AdministradorDeTareas.Instance.Iniciar<ProductoTarea>(Vista);
            
        }

        public void IniciarStock()
        {
           
            AdministradorDeTareas.Instance.Iniciar<StockTarea>(Vista);
        }

        public void IniciarVenta()
        {
            
            AdministradorDeTareas.Instance.Iniciar<VentaTarea>(Vista);
            
        }

    }
}
