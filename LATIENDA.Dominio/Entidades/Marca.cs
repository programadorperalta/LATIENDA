using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Marca
    {
        private int _numero;
        private string _descripcion;

        public Marca()
        {

        }

        public Marca(int numero,string descripcion)
        {

        }

        public Marca(Marca aCopiar)
        {
            Descripcion = aCopiar.Descripcion;
            Numero = aCopiar.Numero;
        }
       
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public int Numero { get { return _numero; } set { _numero = value; } }
        




    }
}
