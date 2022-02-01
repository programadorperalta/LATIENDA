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
using Color = LATIENDA.Dominio.Entidades.Color;

namespace LATIENDA.Presentacion.Vistas
{
    public partial class AgregarProductoVista : AgregarProductoVistaConPresentador, IAgregarProductoVista
    {

        public AgregarProductoVista()
        {
            InitializeComponent();

        }

        public void MostrarRubros(List<Rubro> rubros)
        {
            bsRubro.DataSource = rubros;
        }

        public void MostrarMarcas(List<Marca> marcas)
        {
            bsMarca.DataSource = marcas;
        }

        public void MostrarTiposdeTalles(List<TipodeTalle> tiposdetalles)
        {
            bsTipodeTalle.DataSource = tiposdetalles;
        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            if (!ControlarCamposVacios())
            {
                Producto prodAux = new Producto()
                {
                    Marca = cbMarca.SelectedItem as Marca,
                    Rubro = cbRubro.SelectedItem as Rubro,
                    TipodeTalle = cbTipodeTalle.SelectedItem as TipodeTalle
                    
                };

                Presentador.AgregarProductos(prodAux);
              
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
                    string.IsNullOrEmpty(txtDescripcion.Text) ||
                    string.IsNullOrEmpty(costoText.Text) ||
                    string.IsNullOrEmpty(ivaText.Text) || 
                    string.IsNullOrEmpty(costoIVAText.Text) || 
                    string.IsNullOrEmpty(netoGravadoText.Text) || 
                    string.IsNullOrEmpty(preciodeVentaText.Text);
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

        private void precioFinalLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (!ControlarCamposVacios())
            {
                Producto prodAux = new Producto()
                {
                    Marca = cbMarca.SelectedItem as Marca,
                    Rubro = cbRubro.SelectedItem as Rubro,
                    TipodeTalle = cbTipodeTalle.SelectedItem as TipodeTalle

                };

                Presentador.AgregarProductos(prodAux);

            }
            else
            {
                MostrarMensaje("Campos vacios.", Mensaje.ADVERTENCIA);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
    public class AgregarProductoVistaConPresentador : VistaBase<AgregarProductoPresentador> { }
}
