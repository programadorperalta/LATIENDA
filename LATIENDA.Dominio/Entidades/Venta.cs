using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Venta
    {
        #region Atributos
        private int _numeroventa;
        private double _montoventa;
        private DateTime _fecha;
        private Comprobante _comprobante; //preguntar
        private Usuario _usuario;
        private List<Producto> _productos;
        private Cliente _cliente;
        private LineadeVenta _lineadeventa;
        private int _cantidad;
        #endregion



        #region Constructores
        public Venta()
        {

        }

        public Venta(int numero, double monto, Usuario usuario,List<Producto> productos,Cliente cliente,int cantidad,LineadeVenta lineadeVenta)
        {
            _productos = new List<Producto>();
            _productos = productos;

            Numeroventa = numero;
            Monto = monto;
            Usuario = usuario;
            Cliente = cliente;
            Cantidad = cantidad;
            LineadeVenta = lineadeVenta;

        }
        #endregion

        #region Propiedades
        public LineadeVenta LineadeVenta { get { return _lineadeventa; } set { _lineadeventa = value; } }
        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }
        public Cliente Cliente { get { return _cliente; } set { _cliente = value; } }
        public int Numeroventa { get { return _numeroventa; } set { _numeroventa = value; } }
        public double Monto { get { return _montoventa; } set { _montoventa = value; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
        public Comprobante Comprobante { get { return _comprobante; } set { _comprobante = value; } }
        public Usuario Usuario { get { return _usuario; } set { _usuario = value; } }
        public List<Producto> Productos { get { return _productos; } set { _productos = value; } }

        public void AgregarProductos(Producto producto)
        {
            _productos.Add(producto);
        }



        #endregion
    }
}
