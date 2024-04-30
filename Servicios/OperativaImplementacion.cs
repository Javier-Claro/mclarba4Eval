using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mclarba4eval.Dtos;

namespace Mclarba4eval.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        
        public void RegistroLlegada(char[] letraDni) {

            Console.Write("\n\tIntroduce su dni: ");
            string dni = Console.ReadLine();
            
            char letra = dni.LastOrDefault();



        }

        public void MostrarConsultas(int opcion, string especialidad) { 

        }

        public void ImprimirConsultas(int opcion, string especialidad) { 

        }
    }
}
