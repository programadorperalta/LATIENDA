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
        private int _numerocolor;
        private string _descripcion;
        #endregion

        #region Constructores 
        public Color()
        {

        }
        public Color(int numero,string descripcion)
        {
            NumeroColor = numero;
            Descripcion = descripcion;
        }
        #endregion


        #region Propiedades 
        public int NumeroColor
        {
            get { return _numerocolor; }
            set { _numerocolor = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }

        }
        #endregion

    }
}
