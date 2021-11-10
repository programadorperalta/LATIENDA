using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Sucursal : Tienda
    {
        #region Atributos 
        private TipodeSucursal _tipodesucursal;
        private Empleado _empleado;
        private List<Empleado> _empleados;
        private List<Venta> _ventas;
        private Venta _venta;
        private Stock _stock;
        private List<Stock> stocks;
        private List<PuntodeVenta> _puntosdeventa;
        #endregion

        #region Constructores
        public Sucursal()
        {
            _cuit = base.Cuit;
            _ventas = new List<Venta>();
            _empleados = new List<Empleado>();
        }

        public Sucursal(TipodeSucursal tipo,List<Empleado> empleados,List<Stock> stocks,List<PuntodeVenta> puntodeVentas)
        {

        }

        #endregion

        #region Propiedades
        public TipodeSucursal TipodeSucursal { get { return _tipodesucursal; } set { _tipodesucursal = value; } }
        public Empleado Empleado { get { return _empleado; } set { _empleado = value; } }
        public Venta Venta { get { return _venta; } set { _venta = value; } }
        public Stock Stock { get { return _stock; } set { _stock = value; } }
        #endregion

        public void AgregarVentas(Venta venta)
        {
            _ventas.Add(venta);
        }

        public void AgregarEmpleados(Empleado empleado)
        {
            _empleados.Add(empleado);
        }
        
        public List<Empleado> GetEmpleados()
        {
            return _empleados;
        }

        public List<Venta> GetVentas()
        {
            return _ventas;
        }


        public void AgregarPuntosdeVenta(List<PuntodeVenta> puntodeVentas)
        {
            
        }

    }
}
