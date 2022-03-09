using LATIENDA.Infraestructura.Cliente.AccesoExterno.LoginService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Infraestructura.Cliente.AccesoExterno
{
    public interface IAdaptador
    {
        Autorizacion ObtenerAutorizacion(string GUID);

    }
}
