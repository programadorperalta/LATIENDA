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
    public partial class ComprobanteVista : ComprobanteVistaConPresentador, IComprobanteVista
    {
        public ComprobanteVista()
        {
            InitializeComponent();
        }


        public void RecibirComprobante(Comprobante comprobante)
        {
            lbTipodeFactura.Text = comprobante.TipodeComprobante.ToString();
            lbCliente.Text = comprobante.Venta.Cliente.Nombre;
            
            lbNumero.Text = Convert.ToString(16);
            lbFecha.Text = Convert.ToString(comprobante.Fecha);

            CargarCuerpoComprobante(comprobante);
            CargarPieComprobante(comprobante);
        }


        private void CargarCuerpoComprobante(Comprobante comprobante)
        {
            //PRODUCTO $NETO %IVA $IVA $TOTALES
            //
            foreach (LineadeVenta lv in comprobante.Venta.LineasdeVenta)
            {
                dataGridView1.Rows.Add(lv.Stock.Producto.Descripcion, lv.Stock.Producto.NetoGravado, lv.Stock.Producto.PorcentajeIva, lv.Stock.Producto.CostoConIva, lv.Stock.Producto.PreciodeVenta);
            }
        }

        private void CargarPieComprobante(Comprobante comprobante)
        {
            lbTotal.Text = Convert.ToString(comprobante.Venta.Pago.MontoAPagar);
            lbPago.Text = Convert.ToString(comprobante.Venta.Pago.MontoRecibido);
            lbVuelto.Text = Convert.ToString(comprobante.Venta.Pago.Vuelto);
            lbBase.Text = Convert.ToString(comprobante.Venta.LineasdeVenta.Sum(x=>x.Stock.Producto.NetoGravado));
            lbIVA.Text = Convert.ToString(ReglasDeNegocio.IVA);
            lbImporte.Text = Convert.ToString(comprobante.Venta.LineasdeVenta.Sum(x=>x.Stock.Producto.NetoGravado) * ReglasDeNegocio.IVA);
            lbMoneda.Text = "PES";
            lbTipodeCambio.Text = Convert.ToString(1);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Presentador.ConexionServicioExterno();
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
    public class ComprobanteVistaConPresentador : VistaBase<ComprobantePresentador> { }
}
