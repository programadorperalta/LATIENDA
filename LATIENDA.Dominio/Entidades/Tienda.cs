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
        public long _cuit;
        public CondicionTributaria _condiciontributaria;
        public List<Sucursal> _sucursales;

        public Tienda()
        {
            Cuit = 30641405554;
            _sucursales = new List<Sucursal>();
        }

        public void Sucursales()
        {
            _sucursales.Add
                (
                new Sucursal()
                ) ;
        }

        
        public long Cuit { get { return _cuit; } set { _cuit = value; } }


    }
}
