using System;

namespace holaMundo.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; }
        public string AlumnoId{get;set;}

        public Asignatura Asignatura  { get; set; }
        public string AsignaturaId{get;set;}
        
        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Name}, {Asignatura.Name}";
        }
    }
}