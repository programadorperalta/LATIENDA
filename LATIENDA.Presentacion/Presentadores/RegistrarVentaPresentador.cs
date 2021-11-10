using LATIENDA.Dominio;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Presentacion.Presentadores
{
    public class RegistrarVentaPresentador : PresentadorBase<ProductoTarea, IRegistrarVentaVista>
    {
        IRepositorio _repositorio;

        public RegistrarVentaPresentador(IRegistrarVentaVista vista,IRepositorio repositorio):base (vista)
        {
            _repositorio = repositorio;
        }




    }
}
