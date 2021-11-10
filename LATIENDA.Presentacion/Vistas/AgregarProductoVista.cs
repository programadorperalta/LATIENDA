using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LATIENDA.Presentacion.Presentadores;
using LATIENDA.Presentacion.Interfaces;
using System.Text.RegularExpressions;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Datos;

namespace LATIENDA.Presentacion.Vistas
{
    public partial class AgregarProductoVista : AgregarProductoVistaConPresentador, IAgregarProductoVista
    {

        public AgregarProductoVista()
        {
            InitializeComponent();
            precioIVAText.Enabled = false;
            
        }

        public void MostrarRubros(List<Rubro> rubros)
        {
            bsRubro.DataSource = rubros;
        }

        public void MostrarMarcas(List<Marca> marcas)
        {
            bsMarca.DataSource = marcas;
        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            if (!ControlarCamposVacios())
            {
                Presentador.AgregarProductos();
            }
            else 
            {
                MostrarMensaje("Campos vacios.", Mensaje.ADVERTENCIA);
            }
        }

        public void RecibirProducto(Producto producto)
        {
            bsProducto.DataSource = producto; //Mostrar los textbox con datos de entrada
            
        }

        public void MostrarMensaje(string descripcion, Mensaje tipo)
        {
            MessageBox.Show(descripcion, tipo.ToString(), MessageBoxButtons.OK);
        }

        private bool ControlarCamposVacios()
        {
            return  string.IsNullOrEmpty(codigoText.Text) || 
                    string.IsNullOrEmpty(descripcionText.Text) ||
                    string.IsNullOrEmpty(precioBaseText.Text) ||
                    string.IsNullOrEmpty(ivaText.Text) || 
                    string.IsNullOrEmpty(precioFinalText.Text) || 
                    string.IsNullOrEmpty(gananciaText.Text) || 
                    string.IsNullOrEmpty(existenciaText.Text);
        }


        private void codigoText_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros((TextBox)sender);
        }

        private void precioIVAText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ivaText_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros((TextBox)sender);
        }

        private void gananciaText_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros((TextBox)sender);
        }

        private void existenciaText_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros((TextBox)sender);
        }

        private void cbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class AgregarProductoVistaConPresentador : VistaBase<AgregarProductoPresentador> { }
}
