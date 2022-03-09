using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Transversal;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Presentacion.Tareas
{
    public class VentaTarea : TareaBase
    {
        public Venta Venta { get; set; }

        public VentaTarea()
        {

        }

        public override void Iniciar(IVista mdiPadre = null)
        {
            MdiPadre = mdiPadre;
            NavegarA<RegistrarVentaPresentador>(esMdiHijo: true);
        }

    }
}
