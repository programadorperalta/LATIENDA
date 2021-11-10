using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LATIENDA.Dominio;
using LATIENDA.Infraestructura.Datos;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Tareas;
using LATIENDA.Presentacion.Vistas;
using Unity;

namespace LATIENDA.Presentacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new UnityContainer();
            Factoria.Instance.SetContenedor(container);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Registracion de Tipos
            container.RegisterType<IAutenticarUsuarioVista,AutenticarUsuario>();
            container.RegisterType<IPrincipalVista, PrincipalVista>();
            container.RegisterType<IAgregarProductoVista, AgregarProductoVista>();
            container.RegisterType<IListarProductosVista, ListarProductosVista>();
            container.RegisterType<IModificarProductoVista, ModificarProductoVista>();
            container.RegisterSingleton<IRepositorio,Repositorio>();
            #endregion

            AdministradorDeTareas.Instance.Iniciar<PrincipalTarea>();
            Application.Run(Application.OpenForms[0]);
        }
    }
}
