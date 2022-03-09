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

namespace LATIENDA.Presentacion.Vistas
{
    public partial class RegistrarVentaVista : RegistrarVentaVistaConPresentador, IRegistrarVentaVista
    {
        public RegistrarVentaVista()
        {
            InitializeComponent();
        }

        public void RecibirCliente(Cliente cliente)
        {
            bsCliente.DataSource = cliente;
        }

        public void RecibirVenta(Venta venta)
        {
            bsVenta.DataSource = venta;
        }

        public void MostrarTotal(double total)
        {
            txtTotal.Text = Convert.ToString(total);
        }

        public void RecibirPago(Pago pago)
        {
            bsPago.DataSource = pago;
        }

        public void RecibirStock(Stock stock)
        {
            txtDescripcion.Text = stock.Producto.Descripcion;
            txtPreciodeVenta.Text = stock.Producto.PreciodeVenta.ToString();
            txtMarca.Text = stock.Producto.Marca.Descripcion;
            txtTalle.Text = stock.Talle.Descripcion;
            txtColor.Text = stock.Color.Descripcion;
            txtCantidad.Text = stock.Cantidad.ToString();
        }

        public void MostrarTiposdePago(List<TipodePago> tipodePagos)
        {
            bsTipodePago.DataSource = tipodePagos;
        }


        public void CargarTabladeProductos(LineadeVenta lineadeVenta)
        {
           dataGridView1.Rows.Add(lineadeVenta.Cantidad, lineadeVenta.Subtotal, lineadeVenta.Stock.Producto.Descripcion);
        }


        public void RecibirLineaDeVenta(LineadeVenta lineadeVenta)
        {
            bsLineadeVenta.DataSource = lineadeVenta;
        }

        public void MostrarMensaje(string descripcion, Mensaje tipo)
        {
            MessageBox.Show(descripcion, tipo.ToString(), MessageBoxButtons.OK);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Presentador.BuscarCliente(long.Parse(txtCUIT.Text));
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Presentador.BuscarStockdeProducto(Int32.Parse(txtCodigoProducto.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Presentador.AgregarStockALineadeVenta();

            Presentador.CalcularTotal();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentador.GenerarComprobante();
        }
      
    }
    public class RegistrarVentaVistaConPresentador : VistaBase<RegistrarVentaPresentador> { }
}
