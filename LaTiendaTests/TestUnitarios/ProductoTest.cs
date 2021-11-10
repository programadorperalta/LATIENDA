using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LATIENDA.Dominio.Entidades;

namespace LaTiendaTests.TestUnitarios
{
    [TestClass]
    public class ProductoTest
    {

        [TestMethod]
        public void Calcular_El_Precio_De_Venta_de_Un_Producto()
        {
            Producto p2 = new Producto()
            {
                Codigo = 1,
                Descripcion = "Remera",
                Costo = 600,
                MargendeGanancia = 0.05,
                PorcentajeIva = 0.21,
                Rubro = new Rubro(1, "Ropa depotiva"),
                Marca = new Marca(1, "Adidas")
            };

            double valorEsperado = 762.3;

            double valorReal = p2.PreciodeVenta;

            Assert.AreEqual(valorEsperado, valorReal);

        }

        [TestMethod]
        public void Calcular_El_Neto_Gravado_de_Un_Producto()
        {
            Producto p2 = new Producto()
            {
                Codigo = 1,
                Descripcion = "Remera",
                Costo = 600,
                MargendeGanancia = 0.05,
                PorcentajeIva = 0.21,
                Rubro = new Rubro(1, "Ropa depotiva"),
                Marca = new Marca(1, "Adidas")
            };

            double valorEsperado = 630;

            double valorReal = p2.NetoGravado;

            Assert.AreEqual(valorEsperado, valorReal);
        }

        [TestMethod]
        public void Calcular_El_Costo_Con_Iva_de_Un_Producto()
        {
            Producto p2 = new Producto()
            {
                Codigo = 1,
                Descripcion = "Remera",
                Costo = 700,
                MargendeGanancia = 0.05,
                PorcentajeIva = 0.21,
                Rubro = new Rubro(1, "Ropa depotiva"),
                Marca = new Marca(1, "Adidas")
            };

            double valorEsperado = 154.35;

            double valorReal = p2.CostoConIva;

            Assert.AreEqual(valorEsperado, valorReal);
        }



    }
}
