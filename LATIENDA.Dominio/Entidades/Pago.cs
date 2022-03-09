using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Pago
    {
        public int ID { get; set; }
        public virtual TipodePago TipodePago { get; set; }
        public double MontoAPagar { get; set; }
        public double MontoRecibido { get; set; }
        public double Vuelto { get { return - (MontoAPagar - MontoRecibido); } set { } }


        public Pago()
        {

        }



    }
}
