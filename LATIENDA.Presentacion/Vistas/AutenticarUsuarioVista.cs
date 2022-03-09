using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Transversal;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Presentadores;

namespace LATIENDA.Presentacion.Vistas
{
    public partial class AutenticarUsuario : AutenticarUsuarioVistaConPresentador, IAutenticarUsuarioVista
    {
        public AutenticarUsuario()
        {
            InitializeComponent();
        }

        public void RecibirSesion(Sesion sesion)
        {
            bsSesion.DataSource = sesion;
        }

        public void CerrarSesion()
        {
            throw new NotImplementedException();
        }

        public void RecibirUsuario(Usuario user)
        {
            bsUsuario.DataSource = user;
        }

        public void LimpiarCampos()
        {
            txtContraseña.Text = string.Empty;
            txtNombredeUsuario.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentador.ValidarUsuario();
        }

        public void MostrarMensaje(string descripcion, Mensaje tipo)
        {
            MessageBox.Show(descripcion,tipo.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class AutenticarUsuarioVistaConPresentador : VistaBase<AutenticarUsuarioPresentador> { }
}
