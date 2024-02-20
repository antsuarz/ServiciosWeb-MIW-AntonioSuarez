using AppAsturiasServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS.ChargerService.Asturias.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationServicesClient client = new ApplicationServicesClient();
            var cargadores = client.GetCargadoresAsync().Result;
            DefMessages();
            while (true)
            {
                string response = Console.ReadLine();
                switch (response)
                {
                    case "all":
                        foreach (CargadorModel c in cargadores) {
                            Console.WriteLine(c.Title);
                        }
                        DefMessages();
                        break;
                    case "ovd":
                        for(int i = 0; i < 50; i++)
                        {
                            Console.WriteLine(cargadores[i].Title);
                        }
                        DefMessages();
                        break;
                    case "gjn":
                        for(int i = 50; i < cargadores.Length; i++)
                        {
                            Console.WriteLine(cargadores[i].Title);
                        }
                        DefMessages();
                        break;
                    default: 
                        Console.WriteLine("Comando no reconocido (all, ovd, gjn)");
                        break;
                }
            }           
        }

        static void DefMessages() {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Introduzca all para ver los cargadores registrados.");
            Console.WriteLine("Introduzca ovd para ver los cargadores de Oviedo registrados.");
            Console.WriteLine("Introduzca gjn para ver los cargadores de Gijon  registrados.");
        }

    }
}
