using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mclarba4eval.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método que registrará la llegada de los pacientes que tienen cita:
        /// 30/04/2024 - mjcb
        /// </summary>
        public void RegistroLlegada(char[] letraDni);

        /// <summary>
        /// Método que mostrará por pantalla los pacientes que hayan asistido hoy a su consulta de su especialidad:
        /// 30/04/2024 - mjcb
        /// </summary>
        public void MostrarConsultas(int opcion, string especialidad);

        /// <summary>
        /// Método que imprimirá en un fichero todas las consultas de la especialidad específica:
        /// 30/04/2024 - mjcb
        /// </summary>
        public void ImprimirConsultas(int opcion, string especialidad);

    }
}
