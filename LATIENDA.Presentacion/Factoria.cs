using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace LATIENDA.Presentacion
{
    public class Factoria
    {
        private static volatile Factoria _instance;
        private static readonly object _syncLock = new object();

        private UnityContainer _container;

        private Factoria()
        {

        }

        public static Factoria Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if(_instance == null)
                    {
                        _instance = new Factoria();
                    }
                }
                return _instance;
            }
        }

        public void SetContenedor(UnityContainer container)
        {
            _container = container;
        }

        public T Crear<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
