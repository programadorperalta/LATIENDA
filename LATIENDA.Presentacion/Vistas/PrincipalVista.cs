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
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Presentador.IniciarProductos();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Presentador.IniciarStock();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    public class PrincipalVistaConPresentador : VistaBase<PrincipalPresentador> { }
}
