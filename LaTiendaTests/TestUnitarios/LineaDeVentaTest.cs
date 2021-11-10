using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LATIENDA.Dominio.Entidades;
namespace LaTiendaTests
{
    [TestClass]
    public class LineaDeVentaTest
    {
        [TestMethod]
        public void Calcular_el_subtotal_para_un_producto_con_cantidad_4()
        {
            //Configuracion o inicio 
            int cantidad = 4;
            Producto producto = new Producto(1, "Remera",600,0.05,0.21, new Rubro(1, "Ropa depotiva"), new Marca(1, "Adidas"));
            LineadeVenta lineadeVenta = new LineadeVenta(1,producto,cantidad);
            double valorEsperado = 3049.2;
            //ejecucion 
            var valorReal = lineadeVenta.CalcularSubtotal();
            //verificacion 
            Assert.AreEqual(valorEsperado,valorReal);
            //cierre 
        }
    }
}
