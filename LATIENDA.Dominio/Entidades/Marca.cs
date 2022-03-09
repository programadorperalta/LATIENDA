using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Dominio.Entidades
{
    public class Marca
    {
        public int ID { get; set; }
        private string _descripcion;
        //public virtual Producto Producto { get; set; }
        public Marca()
        {

        }

        public Marca(int numero,string descripcion)
        {
            Descripcion = descripcion;
        }

        public Marca(Marca aCopiar)
        {
            Descripcion = aCopiar.Descripcion;
        }
       
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        




    }
}
