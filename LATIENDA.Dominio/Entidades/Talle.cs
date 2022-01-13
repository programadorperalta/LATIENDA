using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Talle
    {
        #region Atributos 
        public int ID { get; set; }
        private string _descripcion;
        private TipodeTalle _tipodetalle;
        #endregion

        public Talle()
        {

        }

        public Talle(string descripcion,TipodeTalle tipodetalle)
        {
            Descripcion = descripcion;
            TipodeTalle = tipodetalle;
        }


        #region Propiedades 
        public TipodeTalle TipodeTalle { get {return _tipodetalle; }set {_tipodetalle = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        #endregion
    }
}
