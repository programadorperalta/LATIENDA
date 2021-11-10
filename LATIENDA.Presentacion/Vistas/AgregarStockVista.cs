using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LATIENDA.Presentacion.Vistas
{
    public partial class AgregarStockVista : AgregarStockVistaConPresentador,IAgregarStockVista
    {
        public AgregarStockVista()
        {
            InitializeComponent();
        }

        

        
    }
    public class AgregarStockVistaConPresentador : VistaBase<AgregarStockPresentador> { }
}
