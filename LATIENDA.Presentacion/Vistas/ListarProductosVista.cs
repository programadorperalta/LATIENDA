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
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;

namespace LATIENDA.Presentacion.Vistas
{
    public partial class ListarProductosVista : ListarProductosVistaConPresentador, IListarProductosVista
    {
        public ListarProductosVista()
        {
            InitializeComponent();
            lista.MultiSelect = false;
            lista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        public void ActualizarTabla(List<Producto> inventario)
        {

            bsProducto.ResetBindings(false);
            bsProducto.DataSource = inventario;
            
            
            //ActualizarBotonModificar();           
        }

        private void ActualizarBotonModificar()
        {
            if (lista.RowCount == 0)
            {
                ModificarButton.Enabled = false;
            }
            else
            {
                ModificarButton.Enabled = true;
            }
        }

        public void MostrarMensaje(string descripcion, Mensaje tipo)
        {
            MessageBox.Show(descripcion, tipo.ToString(), MessageBoxButtons.OK);
        }

        public bool ConfirmarEliminacion()
        {
            DialogResult resultado = MessageBox.Show("Desea eliminar el producto?", "Confirmar Eliminacion", MessageBoxButtons.YesNo);
            return resultado.Equals(DialogResult.Yes) ? true : false;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            Presentador.AgregarProducto();
            //_presentador.ActualizarInventario();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
   
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoModificar = (int)lista.Rows[lista.SelectedCells[1].RowIndex].Cells[1].Value;
                Presentador.ModificarProducto(codigoModificar);
                
            }
            else
                {
                    DialogResult resultado = MessageBox.Show("Vuelva a intentar cuando tenga productos cargados", "No existe producto para modificar", MessageBoxButtons.OK);
                }
            }

        private void BusquedaText_TextChanged(object sender, EventArgs e)
        {
            Presentador.FiltarInventario(BusquedaText.Text);
        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoEliminar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                Presentador.EliminarProducto(codigoEliminar);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Vuelva a intentar cuando tenga productos cargados", "No existe producto para eliminar", MessageBoxButtons.OK);
            }
        }
    }
    public class ListarProductosVistaConPresentador: VistaBase<ListarProductoPresentador> { }
}
