using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Presentacion.Interfaces
{
    public interface IPrincipalVista: IVista
    {
        void MostrarUsuario(string nombre);

    }
}
