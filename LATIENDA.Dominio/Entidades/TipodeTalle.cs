using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class TipodeTalle
    {
        #region Atributos
        public int ID { get; set; }
        private string _descripciontipodetalle;
        #endregion

        #region Constructores
        public TipodeTalle()
        {

        }

        public TipodeTalle(string descripcion)
        {
            Descriptiontipodetalle = descripcion;
        }

        #endregion

        #region Propiedades
        public string Descriptiontipodetalle { 

            get { return _descripciontipodetalle; } 

            set { _descripciontipodetalle = value; } 

        }
        #endregion
    }
}
