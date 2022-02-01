using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
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
using Color = LATIENDA.Dominio.Entidades.Color;

namespace LATIENDA.Presentacion.Vistas
{
    public partial class AgregarStockVista : AgregarStockVistaConPresentador,IAgregarStockVista
    {
        public AgregarStockVista()
        {
            InitializeComponent();
        }

        public void BuscarProducto(int codigo)
        {
            throw new NotImplementedException();
        }

        public void MostrarColores(List<Color> colores)
        {
            bsColor.DataSource = colores;
        }

        public void MostrarTalles(List<Talle> talles)
        {
            bsTalle.DataSource = talles;
        }

        public void RecibirProducto(Producto producto)
        {
            bsProducto.DataSource = producto;
            txtMarca.Text = producto.Marca.Descripcion;
            txtRubro.Text = producto.Rubro.Descripcion;
            txtTipodeTalle.Text = producto.TipodeTalle.Descriptiontipodetalle;

            Presentador.FiltrarTalles(producto.TipodeTalle.ID);
        }

        public void MostrarMensaje(string descripcion, Mensaje tipo)
        {
            MessageBox.Show(descripcion, tipo.ToString(), MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Presentador.BuscarProducto(Int32.Parse(txtCodigo.Text));
            //Filtrar lista por tipos de talles. 
        }

        public void RecibirStock(Stock stock)
        {
            bsStock.DataSource = stock;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ControlarCamposVacios())
            {
                Stock stockAux = new Stock()
                {
                    Talle = cbTalle.SelectedItem as Talle,
                    Color = cbColor.SelectedItem as Color
                };

                Presentador.AgregarStock(stockAux);
            }
            else
            {
                MostrarMensaje("Campos vacios.", Mensaje.ADVERTENCIA);
            }
        }


        private bool ControlarCamposVacios()
        {
            return string.IsNullOrEmpty(codigoText.Text) ||
                    string.IsNullOrEmpty(txtDescripcion.Text) ||
                    string.IsNullOrEmpty(txtCosto.Text) ||
                    string.IsNullOrEmpty(txtIva.Text) ||
                    string.IsNullOrEmpty(txtCostoIva.Text) ||
                    string.IsNullOrEmpty(txtNetoGravado.Text) ||
                    string.IsNullOrEmpty(txtPreciodeVenta.Text);
        }


    }
    public class AgregarStockVistaConPresentador : VistaBase<AgregarStockPresentador> { }
}
