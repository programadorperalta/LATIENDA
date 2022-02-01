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
            

        }

        public void RecibirProducto(Producto producto)
        {
            bsProducto.DataSource = producto;
        }

        private bool ControlarCamposVacios()
        {
            return string.IsNullOrEmpty(codigoText.Text) ||
                    string.IsNullOrEmpty(txtDescripcion.Text) ||
                    string.IsNullOrEmpty(costoText.Text) ||
                    string.IsNullOrEmpty(ivaText.Text) ||
                    string.IsNullOrEmpty(costoIVAText.Text) ||
                    string.IsNullOrEmpty(netoGravadoText.Text) ||
                    string.IsNullOrEmpty(preciodeVentaText.Text);
        }

        public void MostrarMensaje(string descripcion, Mensaje tipo)
        {
            MessageBox.Show(descripcion, tipo.ToString(), MessageBoxButtons.OK);
        }

        private void confirmarBoton_Click_1(object sender, EventArgs e)
        {
            if (!ControlarCamposVacios())
            {
                Producto prodAux = new Producto()
                {
                    Codigo = Int32.Parse(codigoText.Text),
                    Marca = cbMarca.SelectedItem as Marca,
                    Rubro = cbRubro.SelectedItem as Rubro,
                    TipodeTalle = cbTipodeTalle.SelectedItem as TipodeTalle
                };


                Presentador.ModificarProducto(prodAux);
            }
            else
            {
                MostrarMensaje("Campos vacios", Mensaje.ADVERTENCIA);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

    public class ModificarProductoVistaConPresentador: VistaBase<ModificarProductoPresentador> { }
}
