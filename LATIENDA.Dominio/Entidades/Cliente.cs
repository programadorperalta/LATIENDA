using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Cliente
    {
        #region Atributos
        public int ID { get; set; }
        private long _cuit;
        private CondicionTributaria _condiciontributaria;
        private string _nombre;
        private string _domicilio;
        #endregion
        

        #region Constructores
        public Cliente()
        {
            _condiciontributaria = CondicionTributaria.CF;
        }

        public Cliente(long cuit,CondicionTributaria condicion,string nombre,string domicilio)
        {
            Cuit = cuit;
            CondicionTributaria = condicion;
            Nombre = nombre;
            Domicilio = domicilio;
        }
        #endregion


        #region Propiedades
        public CondicionTributaria CondicionTributaria { get { return _condiciontributaria; } set { _condiciontributaria = value; } }
        public long Cuit { get { return _cuit; } set { _cuit = value; } }
        public string Nombre { get { return _nombre; } set { _nombre= value; } }
        public string Domicilio { get { return _domicilio; } set { _domicilio = value; } }
        #endregion

    }
}
