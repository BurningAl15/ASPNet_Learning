using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace holaMundo.Models
{
    public class EscuelaContext:DbContext{
        public DbSet<Escuela> Escuelas{get;set;}
        public DbSet<Asignatura> Asignaturas{get;set;}

        public DbSet<Curso> Cursos{get;set;}
        public DbSet<Evaluación> Evaluaciones{get;set;}
        public DbSet<Alumno> Alumnos{get;set;}
        
        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela("Camacho's School", 2005);
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Country = "Perú";
            escuela.City="Lima";
            escuela.Direction="Jr. Cerro Prieto 118";

            //What to do when don't have data
            modelBuilder.Entity<Escuela>().HasData(
                escuela
            );

            modelBuilder.Entity<Asignatura>().HasData(
                        new Asignatura{Name="Matemáticas",
                        Id=Guid.NewGuid().ToString()} ,
                        new Asignatura{Name="Educación Física",
                        Id=Guid.NewGuid().ToString()},
                        new Asignatura{Name="Castellano",
                        Id=Guid.NewGuid().ToString()},
                        new Asignatura{Name="Ciencias Naturales",
                        Id=Guid.NewGuid().ToString()}
            );

            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar().ToArray());

        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Name = $"{n1} {n2} {a1}",
                               Id=Guid.NewGuid().ToString() };

            return listaAlumnos.OrderBy((al) => al.Id).ToList();
        }

    }
}