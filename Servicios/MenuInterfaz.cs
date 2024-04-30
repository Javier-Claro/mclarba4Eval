using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mclarba4eval.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que preguntará al usuario acerca del registo de llegada o listado de consultas:
        /// </summary>
        /// 30/04/2024 - mjcb
        /// <returns>La opción deseada</returns>
        public int MenuPrincipal(int opcion);

        /// <summary>
        /// Método que preguntará al usuario si desea que se imprima por pantalla las consultas o, escrito en un
        /// fichero, las consultas a las que los pacientes han asistido:
        /// </summary>
        /// 30/04/2024 - mjcb
        /// <returns>La opción deseada</returns>
        public int MenuListadoConsultas(int opcion);

        /// <summary>
        /// Método que preguntará al usuario qué consulta desea ver:
        /// </summary>
        /// 30/04/2024 - mjcb
        /// <returns>La opción deseada</returns>
        public int MenuConsulta(int opcion);
    }
}
