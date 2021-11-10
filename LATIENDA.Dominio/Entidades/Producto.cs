using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Producto
    {
        #region Atributos
        private int _codigo;
        private string _descripcion;
        private double _costo;
        private double _margendeganancia;
        private double _netogravado;
        private double _porcentajeiva;
        private double _costoconiva; //este esta afectado por el porcentaje de IVA. 
        private double _preciodeventa;
        private Rubro _rubro;
        private Marca _marca;
        #endregion

        #region Constructores
        public Producto()
        {

        }

        public Producto(int codigo, string descripcion, double costo, double margendeganancia, double porcentajeiva, Rubro rubro, Marca marca)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Costo = costo;
            MargendeGanancia = margendeganancia;
            Rubro = rubro;
            Marca = marca;

        }


        public Producto(int codigo,string descripcion,double costo,double margendeganancia,
            double netogravado,double porcentajeiva,double costoconiva,
            double preciodeventa,Rubro rubro,Marca marca)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Costo = costo;
            MargendeGanancia = margendeganancia;


        }


        public Producto(Producto aCopiar)
        {
            Codigo = aCopiar.Codigo;
            Descripcion = aCopiar.Descripcion;
            PorcentajeIva = aCopiar.PorcentajeIva;
            Costo = aCopiar.Costo;
            MargendeGanancia = aCopiar.MargendeGanancia;
            NetoGravado = aCopiar.NetoGravado;
            CostoConIva = aCopiar.CostoConIva;
            PreciodeVenta = aCopiar.PreciodeVenta;
            Marca = aCopiar.Marca;
            Rubro = aCopiar.Rubro;
        }
        #endregion



        #region Propiedades

        public int MarcaID { get; set; }
        public int RubroID { get; set; }

        public virtual Marca Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public virtual Rubro Rubro
        {
            get { return _rubro; }
            set { _rubro = value; }
        }
        public int Codigo { get { return _codigo; } set { _codigo = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        /*Todos los productos tienen IVA del 21%. Este valor podria modificarse*/
        public double PorcentajeIva { get { return _porcentajeiva = 0.21; } set { _porcentajeiva = value; } }
        /*Al ingresar la mercaderia se indica el costo (lo que se paga al proveedor) del producto.
         Este valor es siempre sin el IVA incluido. 
         */

        public double Costo { get { return _costo; } set { _costo = value; } }

        /*Los precios de venta de los productos se definen a partir del COSTO, EL MARGEN DE GANANCIA
         * y el valor del impuesto. Es decir: 
         * Neto Gravado = Costo + Costo * Margen de ganancia. 
         * Costoconiva = Neto Gravado * Porcentaje de IVA. 
         * Precio de venta = Neto Gravado + CostoconIva. 
         */
        
        public double MargendeGanancia { get { return _margendeganancia; } set { _margendeganancia = value; } }
        public double NetoGravado { get { return Costo + Costo * MargendeGanancia; } set { _netogravado = value; } }
        public double CostoConIva { get { return _costoconiva = NetoGravado * PorcentajeIva; } set { _costoconiva = value; } }
        public double PreciodeVenta { get { return _preciodeventa = NetoGravado + CostoConIva; } set { _preciodeventa = value; } }


        #endregion


       

       
    }
}
