using LATIENDA.Web.API.Models.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{
    public class Cliente
    {
        #region Propiedades
        public int ID { get; set; }
        public long Cuit { get; set; }
        public virtual CondicionTributaria CondicionTributaria { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        #endregion
       
    }
}
