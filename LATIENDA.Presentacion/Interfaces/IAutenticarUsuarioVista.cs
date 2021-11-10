using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;

namespace LATIENDA.Presentacion.Interfaces
{
    public interface IAutenticarUsuarioVista : IVista
    {

        void RecibirUsuario(Usuario user);
        void ValidarUsuario();
        void CerrarSesion();
        void MostrarMensaje(string descripcion, Mensaje tipo);

    }
}
