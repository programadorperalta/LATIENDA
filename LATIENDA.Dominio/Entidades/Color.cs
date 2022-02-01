using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Color
    {
        #region Atributos 
        public int ID { get; set; }
        private string _descripcion;
        #endregion

        #region Constructores 
        public Color()
        {

        }
        public Color(int numero,string descripcion)
        {
            Descripcion = descripcion;
        }
        #endregion


        #region Propiedades 
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }

        }
        #endregion

    }
}
