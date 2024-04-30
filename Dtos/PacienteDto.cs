using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mclarba4eval.Dtos
{
    /// <summary>
    /// Clase principal que nos ayuda a guardar los datos de cada paciente
    /// 30/04/2024 - mjcb
    /// </summary>
    internal class PacienteDto
    {
        int dni = 11111;
        string nombre = "aaaaa";
        string apellidos = "aaaaa";
        string especialidad = "aaaaa";
        DateTime fechaDeCita;
        bool asistenciaAcita = false;

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaDeCita { get => fechaDeCita; set => fechaDeCita = value; }
        public bool AsistenciaAcita { get => asistenciaAcita; set => asistenciaAcita = value; }

        public PacienteDto(int dni, string nombre, string apellidos, string especialidad, DateTime fechaDeCita, bool asistenciaAcita)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Especialidad = especialidad;
            this.FechaDeCita = fechaDeCita;
            this.AsistenciaAcita = asistenciaAcita;
        }

        public PacienteDto() { }
    }
}
