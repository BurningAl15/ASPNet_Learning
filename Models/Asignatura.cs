using System;
using System.Collections.Generic;

namespace holaMundo.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        // public Asignatura(){
        //     Name="Matemáticas";
        //     Id=Guid.NewGuid().ToString();
        // }

        public string CursoId{get;set;}
        public Curso Curso{get;set;}

        public List<Evaluación> Evaluaciones{get;set;}
    }
}