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
    public class StockTarea : TareaBase
    {

        public StockTarea()
        {

        }

        public override void Iniciar(IVista mdiPadre = null)
        {
            MdiPadre = mdiPadre;
            NavegarA<AgregarStockPresentador>(esMdiHijo: true);
        }


    }
}
