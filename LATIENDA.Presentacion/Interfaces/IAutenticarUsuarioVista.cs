using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Transversal;

namespace LATIENDA.Presentacion.Interfaces
{
    public interface IAutenticarUsuarioVista : IVista
    {

        void RecibirUsuario(Usuario user);
        void CerrarSesion();
        void MostrarMensaje(string descripcion, Mensaje tipo);
        void RecibirSesion(Sesion sesion);

    }
}
