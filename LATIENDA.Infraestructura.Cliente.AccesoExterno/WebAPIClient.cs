using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace LATIENDA.Infraestructura.Cliente.AccesoExterno
{
    public class WebAPIClient : HttpClient
    {
        public WebAPIClient(string baseURL) : base(new HttpClientHandler {Proxy=null,UseProxy=false })
        {
            BaseAddress = new Uri(baseURL);
            Timeout = TimeSpan.FromMinutes(5);
        }

        public async Task<string> PostURI<T>(string u, T clase)
            where T:class
        {
            var response = string.Empty;

            var json = JsonConvert.SerializeObject(clase); //primero serializar el objeto

            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.PostAsync(new Uri($"{BaseAddress.AbsoluteUri}{u}"), stringContent);
                
                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                }
            }
            return response;
        }


        public async Task<string> PutURI<T>(string u, T clase)
            where T : class
        {
            var response = string.Empty;

            var json = JsonConvert.SerializeObject(clase); //primero serializar el objeto

            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.PutAsync(new Uri($"{BaseAddress.AbsoluteUri}{u}"), stringContent);

                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                }
            }
            return response;
        }


        public async Task<string> GetURI(string uri)
        {
            var response = string.Empty;
            
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(new Uri($"{BaseAddress.AbsoluteUri}{uri}"));
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        }


        public async Task<string> DeleteURI(string u)
        {
            var response = string.Empty;

            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.DeleteAsync(new Uri($"{BaseAddress.AbsoluteUri}{u}"));

                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                }
            }
            return response;
        }


    }



}

