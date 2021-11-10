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
        private string _descripciontipodetalle;
        private List<Talle> _talles;
        
        #endregion

        #region Constructores
        public TipodeTalle(string descripcion)
        {
            Descriptiontipodetalle = descripcion;
        }

        public TipodeTalle(List<Talle> talles)
        {

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
