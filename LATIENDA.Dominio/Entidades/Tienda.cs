using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Tienda
    {
        public int ID { get; set; }
        public long Cuit { get; set; }
        public string Nombre { get; set; }
        public CondicionTributaria CondicionTributaria { get; set; }
        public virtual ICollection<Sucursal> Sucursales { get; set; }
        

        public Tienda()
        {
            Nombre = "Mi Tienda Indumentaria y Calzado";
            CondicionTributaria = CondicionTributaria.RI;
        }

    }
}
