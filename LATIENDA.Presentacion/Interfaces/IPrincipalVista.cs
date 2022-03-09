using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Presentacion.Interfaces
{
    public interface IPrincipalVista: IVista
    {
        void MostrarUsuario(Sesion sesion);
        void RecibirTienda(Tienda tienda);
        void MostrarMensaje(string descripcion, Mensaje tipo);
        
    }
}
