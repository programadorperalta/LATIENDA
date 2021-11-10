using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Presentadores;

namespace LATIENDA.Presentacion.Vistas
{
    public partial class PrincipalVista : PrincipalVistaConPresentador, IPrincipalVista
    {
        public PrincipalVista()
        {
            InitializeComponent();
            txtNombreUsuario.Enabled = false;
            
        }



        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentador.IniciarProductos();
        }



        private void MostrarAdvertencia()
        {
            MessageBox.Show("", "ADVERTENCIA", MessageBoxButtons.OK);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void MostrarUsuario(string nombre)
        {
            txtNombreUsuario.Text = $"Bienvenid@: {nombre}";
        }
    }

    public class PrincipalVistaConPresentador : VistaBase<PrincipalPresentador> { }
}
