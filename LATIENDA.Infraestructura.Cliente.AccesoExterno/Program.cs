using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Infraestructura.Cliente.AccesoExterno
{
    public class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Bienvenid@, obteniendo credenciales.... \n");
            string GUID = "267A16AF-7368-403C-A161-D037A8E92774";


            var adapter = Adaptador.ObtenerAutorizacion(GUID);

            if (adapter.Cuit != 0)
            {
                System.Console.WriteLine($" \n Se obtuvieron las credenciales con exito!!\n");
                System.Console.WriteLine($" \n Su CUIT: {adapter.Cuit}\n");
                System.Console.WriteLine($" \n Su Sign: {adapter.Sign}\n");
                System.Console.WriteLine($" \n Se Token:{adapter.Token}\n");
                System.Console.WriteLine("Pulse una tecla para continuar...");
                System.Console.ReadLine();

            }

            else
            {

                System.Console.WriteLine($"\n{adapter.Error} \n");
                System.Console.WriteLine("Intente nuevamente... \n");
                System.Console.ReadLine();

            }





        }
    }
}
