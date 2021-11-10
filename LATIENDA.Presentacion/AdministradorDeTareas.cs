using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Tareas;

namespace LATIENDA.Presentacion
{
    public class AdministradorDeTareas
    {
        #region Implementacion Singleton
        private static volatile AdministradorDeTareas _instance;
        private static readonly object _syncLock = new object();

        private AdministradorDeTareas()
        {

        }

        public static AdministradorDeTareas Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new AdministradorDeTareas();
                    }
                }
                return _instance;
            }
        }
        #endregion

        public void Iniciar<TTarea>(IVista mdiPadre = null)
            where TTarea : ITarea
        {
            var tarea = Factoria.Instance.Crear<TTarea>();
            tarea.Iniciar(mdiPadre);
        }
    }
}
