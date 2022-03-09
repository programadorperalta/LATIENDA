using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{ 
    public class Talle
    {
        #region Propiedades 
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public virtual TipodeTalle TipodeTalle { get; set; }
        #endregion
    }
}
