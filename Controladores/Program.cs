using Mclarba4eval.Controladores;
using Mclarba4eval.Dtos;
using Mclarba4eval.Servicios;
using System.IO;
using System;

namespace Mclarba4eval.Controladores
{
    class Program
    {
        /// <summary>
        /// Clase Main del programa
        /// 30/04/2024 - mjcb
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int opcion = 4;
            string especialidad = "pollo";
            char[] letraDni = {'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};

            MenuInterfaz Menu = new MenuImplementacion();
            OperativaInterfaz Oper = new OperativaImplementacion();
            FicheroInterfaz fich = new FicheroImplementacion();

            do
            {
                opcion = Menu.MenuPrincipal(opcion);

                switch (opcion)
                {
                    case 1:
                        Oper.RegistroLlegada(letraDni);
                        break;

                        case 2:                       
                          opcion = Menu.MenuListadoConsultas(opcion);

                            switch (opcion) { 
                            
                                case 1: 
                                   opcion = Menu.MenuConsulta(opcion);

                                    switch (opcion)
                                    {
                                        case 1:
                                        especialidad = "Psicología";
                                        break;

                                        case 2:
                                        especialidad = "Traumatología";
                                        break;

                                        case 3:
                                        especialidad = "Fisioterapia";
                                        break;
                                    }

                                    Oper.MostrarConsultas(opcion, especialidad);
                                    break;

                                case 2:
                                   opcion = Menu.MenuConsulta(opcion);

                                    switch (opcion)
                                    {
                                        case 1:
                                        especialidad = "Psicología";
                                        break;

                                        case 2:
                                        especialidad = "Traumatología";
                                        break;

                                        case 3:
                                        especialidad = "Fisioterapia";
                                        break;
                                    }

                                Oper.ImprimirConsultas(opcion, especialidad);
                                break;
                            }                       
                        break;
                    }
            }while (opcion != 0);
        }
    }
}
