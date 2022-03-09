using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class PuntodeVenta
    {
        #region Atributos 
        public int ID { get; set; }
        public int Numero { get; set; }
        public Venta Venta { get; set; }
        #endregion


        #region Constructores
        public PuntodeVenta()
        {
           
        }
        #endregion


      

    }
}
