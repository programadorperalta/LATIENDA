using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Comprobante
    {
        #region Atributos 
        public int ID { get; set; }
        public int Numero { get; set; }
        public TipodeComprobante TipodeComprobante { get; set; }
        public virtual PuntodeVenta PuntodeVenta { get; set; }
        public string Fecha { get; set; }
        #endregion

        #region Constructores
        public Comprobante()
        {
            Fecha = DateTime.Now.ToString("yyyyMMdd");
            //string fechaSalida = Fecha.ToString("yyyymmdd");
        }
        #endregion

    }
}
