using LATIENDA.Web.API.Models.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Web.API.Models
{
    public class Tienda
    {
        public int ID { get; set; }
        public long Cuit { get; set; }
        public string Nombre { get; set; }
        public CondicionTributaria CondicionTributaria { get; set; }
        public virtual ICollection<Sucursal> Sucursales { get; set; }
    }
}
