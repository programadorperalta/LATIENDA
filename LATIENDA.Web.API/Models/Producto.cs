using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{
    public class Producto
    {
        #region Propiedades
        public int ID { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double MargendeGanancia { get; set; }
        public double NetoGravado { get; set; }
        public double CostoConIva { get; set; }
        public double PreciodeVenta { get; set; }
        public double PorcentajeIva { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Rubro Rubro { get; set; }
        public virtual TipodeTalle TipodeTalle { get; set; }
        #endregion

        public Producto()
        {

        }
    }
}
