using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Infraestructura.Cliente.AccesoExterno;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            var t = Task.Run(() => GetURI(new Uri("https://localhost:44346//api/Clientes")));
            t.Wait();

            JArray j = JArray.Parse(t.Result);
            Console.WriteLine(j);
            Console.ReadLine();


        }


        static async Task<string> PostURI(Uri u, HttpContent c)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.PostAsync(u, c);
                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                }
            }
            return response;
        }



        static async Task<string> GetURI(Uri u)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        }
    }

}

