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

namespace LATIENDA.Presentacion.Presentadores
{
    public class AutenticarUsuarioPresentador : PresentadorBase<PrincipalTarea, IAutenticarUsuarioVista>
    {
        IRepositorio _repositorio;


        public AutenticarUsuarioPresentador(IAutenticarUsuarioVista vista,
           IRepositorio repositorio) : base(vista)
        {
            _repositorio = repositorio;
            
        }


        public void ValidarUsuario(string usuario,string contraseña)
        {
            if(_repositorio.ValidarUsuario(usuario, contraseña))
            {
                Vista.MostrarMensaje($"Bienvenido: {usuario}",Mensaje.EXITO);
                IniciarPrograma(usuario);
            }
            else
            {
                Vista.MostrarMensaje("Error no se encuentra el usuario", Mensaje.ERROR);
            }
        }



        public void IniciarPrograma(string usuario)
        {
            Tarea.NombredeUsuario = usuario;
            Tarea.NavegarA<PrincipalPresentador>(esDialogo: false, esMdiHijo: false);
        }


    }
}
