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
        public virtual CondicionTributaria CondicionTributaria { get; set; }
        public virtual TipoDeDocumento TipoDeDocumento { get; set; }

        private string _nombre;
        private string _domicilio;
        #endregion
       

        #region Constructores
        public Cliente()
        {

        }

        #endregion


        #region Propiedades
        public long Cuit { get { return _cuit; } set { _cuit = value; } }
        public string Nombre { get { return _nombre; } set { _nombre= value; } }
        public string Domicilio { get { return _domicilio; } set { _domicilio = value; } }
        #endregion

    }
}
