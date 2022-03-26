using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Infraestructura.Cliente.AccesoExterno
{
    public static class AdapterAPI
    {

        public static List<T> GetList<T>(string uri)
            where T : class
        {
            var client = new WebAPIClient("https://localhost:44346/");

            var t = Task.Run(() => client.GetURI(uri));
            t.Wait();

            List<T> lista = JsonConvert.DeserializeObject<List<T>>(t.Result);

            return lista;
        }


        public static Task<string> Post<T>(string uri, T clase)
            where T:class
        {
            var client = new WebAPIClient("https://localhost:44346/");

            var t = Task.Run(()=>client.PostURI(uri,clase));
            t.Wait();

            return t;
        }

        public static Task<string> Put<T>(string uri, T clase)
            where T : class
        {
            var client = new WebAPIClient("https://localhost:44346/");

            var t = Task.Run(() => client.PutURI(uri, clase));
            t.Wait();

            return t;
        }


        public static Task<string> Delete(string uri)
        {
            var client = new WebAPIClient("https://localhost:44346/");

            var t = Task.Run(() => client.DeleteURI(uri));
            t.Wait();

            return t;

        }


        public static T Get<T>(string uri)
            where T : class
        {
            var client = new WebAPIClient("https://localhost:44346/");

            var t = Task.Run(() => client.GetURI(uri));
            t.Wait();

            T elemento = JsonConvert.DeserializeObject<T>(t.Result);

            return elemento;
        }





    }
}
