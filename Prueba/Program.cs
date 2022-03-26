using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Infraestructura.Cliente.AccesoExterno;
using Newtonsoft.Json;
using LATIENDA.Dominio.Entidades;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (Cliente a in AdapterAPI.GetList<Cliente>("api/Clientes"))
            {
                Console.WriteLine(a.Cuit);
            }
            
            Console.ReadLine();
            


        }

    }

}

