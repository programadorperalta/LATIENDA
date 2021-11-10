using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Tareas;

namespace LATIENDA.Presentacion.Presentadores
{
    public class PrincipalPresentador : PresentadorBase<PrincipalTarea, IPrincipalVista>
    {

        public override PrincipalTarea Tarea
        {
            get => base.Tarea;
            set
            {
                base.Tarea = value;
                MostrarUsuario();
            }
        }


        public PrincipalPresentador(IPrincipalVista vista) : base(vista)
        {
            
        }

        public void MostrarUsuario()
        {
            Vista.MostrarUsuario(Tarea.NombredeUsuario);
        }


        public void IniciarProductos()
        {
            AdministradorDeTareas.Instance.Iniciar<ProductoTarea>(Vista);
            
        }
    }
}
