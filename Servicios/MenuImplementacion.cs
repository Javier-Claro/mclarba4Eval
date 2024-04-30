using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mclarba4eval.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int MenuPrincipal(int opcion) {
            do { 
            Console.WriteLine("\n\t\t----------Bienvenido----------");
            Console.WriteLine("\t\t----------(1).Registro de llegada:----------");
            Console.WriteLine("\t\t----------(2).Listado de consultas:----------");
            Console.WriteLine("\t\t----------(0).Salir:----------");
            Console.Write("\n\t\t\tIndique la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                if (opcion < 0 || opcion > 2) { 
                    Console.WriteLine("\n\t\t**ERROR** la opción deseada no existe: ");
                }
            } while( opcion <0 || opcion > 2);
            return opcion;
        }

        public int MenuListadoConsultas(int opcion) {
            do { 
            Console.WriteLine("\n\t\t----------(1).Mostrar consultas:----------");
            Console.WriteLine("\t\t----------(2).Imprimir consultas:----------");
            Console.Write("\n\t\t\tIndique la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                if (opcion < 1 || opcion > 2)
                    Console.WriteLine("\n\t\t**ERROR** la opción deseada no existe: ");

            } while (opcion < 1 || opcion > 2);
            return opcion;
        }

        public int MenuConsulta(int opcion) {
            do { 
            Console.WriteLine("\n\t\t----------(1).Psicología:----------");
            Console.WriteLine("\t\t----------(2).Traumatología:----------");
            Console.WriteLine("\t\t----------(3).Fisioterapia:----------");
            Console.Write("\n\t\t\tIndique la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                if (opcion < 1 || opcion > 3)
                    Console.WriteLine("\n\t\t**ERROR** la opción deseada no existe: ");

            } while (opcion < 1 || opcion > 3) ;
            return opcion;
        }
    }
}
