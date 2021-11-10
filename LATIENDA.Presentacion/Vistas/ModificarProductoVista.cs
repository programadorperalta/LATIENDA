using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LATIENDA.Presentacion.Presentadores;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;

namespace LATIENDA.Presentacion.Vistas
{
    public partial class ModificarProductoVista : ModificarProductoVistaConPresentador, IModificarProductoVista
    {

        public ModificarProductoVista()
        {
            InitializeComponent();
            estadoComboBox.DataSource = Enum.GetValues(typeof(EstadoProducto));
        }
        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            if (!ControlarCamposVacios()) 
            {
                Presentador.ModificarProducto();                  
            }
            else
            {
                MostrarMensaje("Campos vacios", Mensaje.ADVERTENCIA);
            }

        }

        public void RecibirProducto(Producto producto)
        {
            bindingSource.DataSource = producto;
        }

        private bool ControlarCamposVacios()
        {
            return string.IsNullOrEmpty(codigoText.Text) ||
                    string.IsNullOrEmpty(descripcionText.Text) ||
                    string.IsNullOrEmpty(precioBaseText.Text) ||
                    string.IsNullOrEmpty(ivaText.Text) ||
                    string.IsNullOrEmpty(precioFinalText.Text) ||
                    string.IsNullOrEmpty(gananciaText.Text) ||
                    string.IsNullOrEmpty(existenciaText.Text);
        }

        public void MostrarMensaje(string descripcion, Mensaje tipo)
        {
            MessageBox.Show(descripcion, tipo.ToString(), MessageBoxButtons.OK);
        }

    }

    public class ModificarProductoVistaConPresentador: VistaBase<ModificarProductoPresentador> { }
}
