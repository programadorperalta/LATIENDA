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
        public int ID { get; set; }
        private int _codigo;
        private string _descripcion;
        private double _costo;
        private double _margendeganancia;
        private double _netogravado;
        private double _porcentajeiva;
        private double _costoconiva; //este esta afectado por el porcentaje de IVA. 
        private double _preciodeventa;
        public virtual Marca Marca { get; set; }
        public virtual Rubro Rubro { get; set; }
        public virtual TipodeTalle TipodeTalle { get; set; }
        #endregion

        public Producto()
        {

        }

        public Producto(Producto aCopiar)
        {
            ID = aCopiar.ID;
            Codigo = aCopiar.Codigo;
            Descripcion = aCopiar.Descripcion;
            Costo = aCopiar.Costo ;
            MargendeGanancia = aCopiar.MargendeGanancia;
            NetoGravado = aCopiar.NetoGravado;
            PorcentajeIva = aCopiar.PorcentajeIva;
            CostoConIva = aCopiar.CostoConIva;
            PreciodeVenta = aCopiar.PreciodeVenta;
            Marca = aCopiar.Marca;
            Rubro = aCopiar.Rubro;
            TipodeTalle = aCopiar.TipodeTalle;
        }

        #region Propiedades
        public int Codigo { 
            
            get {
                return _codigo ; 
            } set { 
                _codigo = value; 

            } 
        }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        /*Todos los productos tienen IVA del 21%. Este valor podria modificarse*/
        public double PorcentajeIva { get { return _porcentajeiva = ReglasDeNegocio.IVA; } set { _porcentajeiva = value; } }
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
        public double NetoGravado { get { return _netogravado = _costo + _costo * _margendeganancia; } set { _netogravado = value; } }
        public double CostoConIva { get { return _costoconiva = _netogravado * _porcentajeiva; } set { _costoconiva = value; } }
        public double PreciodeVenta { get { return _preciodeventa = _netogravado + _costoconiva; } set { _preciodeventa = value; } }

        #endregion






    }
}
