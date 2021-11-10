using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Presentadores;

namespace LATIENDA.Presentacion.Tareas
{
    public class PrincipalTarea : TareaBase
    {
        public string NombredeUsuario { get; set; }


        public PrincipalTarea()
        {
            
        }

        public override void Iniciar(IVista mdiPadre = null)
        {
            MdiPadre = mdiPadre;
            NavegarA<AutenticarUsuarioPresentador>();
        }
    }
}
