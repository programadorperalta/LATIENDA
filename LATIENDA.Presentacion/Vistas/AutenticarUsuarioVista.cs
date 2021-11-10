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

        public void CerrarSesion()
        {
            throw new NotImplementedException();
        }

        public void RecibirUsuario(Usuario user)
        {
            throw new NotImplementedException();
        }

        public void ValidarUsuario()
        {
            if (!string.IsNullOrEmpty(txtContraseña.Text) && !string.IsNullOrEmpty(txtNombredeUsuario.Text))
            {
                    Presentador.ValidarUsuario(txtNombredeUsuario.Text, txtContraseña.Text);
                    LimpiarCampos();
            }
            else
            {
                MostrarMensaje("Error: Debe Ingresar Todos los campos",Mensaje.ERROR);
            }
        }


        public void LimpiarCampos()
        {
            txtContraseña.Text = string.Empty;
            txtNombredeUsuario.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }

        public void MostrarMensaje(string descripcion, Mensaje tipo)
        {
            MessageBox.Show(descripcion,tipo.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
    public class AutenticarUsuarioVistaConPresentador : VistaBase<AutenticarUsuarioPresentador> { }
}
