using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Tareas;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Datos;
using LATIENDA.Infraestructura.Transversal;

namespace LATIENDA.Presentacion.Presentadores
{
    public class AutenticarUsuarioPresentador : PresentadorBase<PrincipalTarea, IAutenticarUsuarioVista,ISesion>
    {
        private readonly IRepositorio _repositorio;
        Sesion _sesionSource;
        Usuario _usuarioSource;
        
        public AutenticarUsuarioPresentador(IAutenticarUsuarioVista vista,
           IRepositorio repositorio,ISesion sesion) : base(vista,sesion)
        {
            _repositorio = repositorio;
            CrearUsuarioSource();
            CrearSesionSource();
            
            
        }

        public void CrearSesionSource()
        {
            _sesionSource = null;
            _sesionSource = new Sesion();
            Vista.RecibirSesion(_sesionSource);
            
        }

        public void CrearUsuarioSource()
        {
            _usuarioSource = null;
            _usuarioSource = new Usuario();
            Vista.RecibirUsuario(_usuarioSource);
        }


        public void ValidarUsuario()
        {
            if(_repositorio.BuscarUsuario(_usuarioSource) != null)
            {
                _usuarioSource = _repositorio.BuscarUsuario(_usuarioSource);
                _sesionSource.Usuario = _usuarioSource;

                Vista.MostrarMensaje($"Bienvenido: {_usuarioSource.Empleado.Nombre}",Mensaje.EXITO);
                IniciarPrograma();
            }

            else
            {
                Vista.MostrarMensaje("Error no se encuentra el usuario", Mensaje.ERROR);
            }
        }

        public void IniciarPrograma()
        {
            Tarea.Sesion = _sesionSource;
            Sesion.EnviarUsuario(_usuarioSource);
            Tarea.NavegarA<PrincipalPresentador>(esDialogo: false, esMdiHijo: false);
        }


    }
}
