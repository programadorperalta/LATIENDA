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
        public int ID { get; set; }
        private int _numero;
        private Cliente _cliente;
        private DateTime _fechayhora;
        private Usuario _usuario; //del sistema 
        private List<Producto> _productos;
        private LineadeVenta _lineadeVenta;

        #endregion

        public Venta(int numero, Cliente cliente, Usuario user, List<Producto> productos)
        {
            FechayHora = DateTime.Now;
            Numero = numero;
            Cliente = cliente;
            User = user;
            Productos = productos;
        }


        #region Propiedades 
        public DateTime FechayHora { get { return _fechayhora; } set { _fechayhora = value; } }
        public LineadeVenta LDV { get { return _lineadeVenta; } set { _lineadeVenta = value; } }
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public Usuario User
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public List<Producto> Productos
        {
            get { return _productos; }
            set { _productos = value; }
        }
        #endregion
    }
}
