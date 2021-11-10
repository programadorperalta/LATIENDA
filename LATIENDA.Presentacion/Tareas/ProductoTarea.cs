using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Presentadores;

namespace LATIENDA.Presentacion.Tareas
{
    public class ProductoTarea: TareaBase
    {
        public int ProductoId { get; set; }
        public string NombreUsuario { get; set; }

        public ProductoTarea()
        {
            
        }

        public override void Iniciar(IVista mdiPadre = null)
        {
            MdiPadre = mdiPadre;
            NavegarA<ListarProductoPresentador>(esMdiHijo: true);
        }
    }
}
