using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace holaMundo.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }

        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Curso> Curso { get; set; }

        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.CreationYear=2005;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Name="Camacho's School";
            escuela.Country = "Perú";
            escuela.City = "Lima";
            escuela.Direction = "Jr. Cerro Prieto 118";
            escuela.school_Type = TiposEscuela.Secundaria;

            //Cargar Cursos de la Escuela
            var cursos = CargarCursos(escuela);

            //x cada curso cargar asignaturas
            var asignaturas = CargarAsignaturas(cursos);

            //x cada curso cargar alumnos
            var alumnos = CargarAlumnos(cursos);

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());

            // var listaAsignaturas = new List<Asignatura>(){
            //                 new Asignatura{Name="Matemáticas"} ,
            //                 new Asignatura{Name="Educación Física"},
            //                 new Asignatura{Name="Castellano"},
            //                 new Asignatura{Name="Ciencias Naturales"},
            //                 new Asignatura{Name="Programacion"}
            //     };
            // modelBuilder.Entity<Asignatura>().HasData(listaAsignaturas);

            // modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar(5).ToArray());
        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();

            Random rnd = new Random();
            foreach (var curso in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura> ();
            foreach (var curso in cursos)
            {
                var tmpList = new List<Asignatura> {
                            new Asignatura{
                                CursoId = curso.Id,
                                Name="Matemáticas"} ,
                            new Asignatura{ CursoId = curso.Id, Name="Educación Física"},
                            new Asignatura{ CursoId = curso.Id, Name="Castellano"},
                            new Asignatura{ CursoId = curso.Id, Name="Ciencias Naturales"},
                            new Asignatura{ CursoId = curso.Id, Name="Programación"}

                };
                listaCompleta.AddRange(tmpList);
                //curso.Asignaturas = tmpList;
            }

            return listaCompleta;
        }

        private static List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>(){
                        new Curso{
                            EscuelaId = escuela.Id,
                            Name = "101",
                            Jornada = TiposJornada.Mañana },
                        new Curso{EscuelaId = escuela.Id, Name = "201", Jornada = TiposJornada.Mañana},
                        new Curso{EscuelaId = escuela.Id, Name = "301", Jornada = TiposJornada.Mañana},
                        new Curso{EscuelaId = escuela.Id, Name = "401", Jornada = TiposJornada.Tarde},
                        new Curso{EscuelaId = escuela.Id, Name = "501", Jornada = TiposJornada.Tarde},
            };
        }

        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad)
        {
            string[] Name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] Name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in Name1
                               from n2 in Name2
                               from a1 in apellido1
                               select new Alumno { CursoId = curso.Id,
                                Name = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    }
}

// namespace holaMundo.Models
// {
//     public class EscuelaContext:DbContext{
//         public DbSet<Escuela> Escuelas{get;set;}
//         public DbSet<Asignatura> Asignaturas{get;set;}

//         public DbSet<Curso> Cursos{get;set;}
//         public DbSet<Evaluación> Evaluaciones{get;set;}
//         public DbSet<Alumno> Alumnos{get;set;}
        
//         public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options){

//         }

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {

//             base.OnModelCreating(modelBuilder);
//             var escuela = new Escuela();
//             escuela.CreationYear=2005;
//             escuela.Id = Guid.NewGuid().ToString();
//             escuela.Name="Camacho's School";
//             escuela.Country = "Perú";
//             escuela.City = "Lima";
//             escuela.Direction = "Jr. Cerro Prieto 118";
//             escuela.school_Type = TiposEscuela.Secundaria;

//             //What to do when don't have data
//             modelBuilder.Entity<Escuela>().HasData(
//                 escuela
//             );

//             //Cargar Cursos de la escuela
//             var cursos = CargarCursos(escuela);

//             //x cada curso cargar asignaturas
//             var asignaturas=CargarAsignaturas(cursos);

//             //x cada curso cargar alumnos
//             var alumnos=CargarAlumnos(cursos);

//             //x cada curso cargar evaluaciones


//             modelBuilder.Entity<Escuela>().HasData(escuela);
//             modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
//             modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
//             modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());
//         }

//         private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
//         {
//             var listaCompleta=new List<Asignatura>();
//             foreach (Curso curso in cursos)
//             {
//                 var tempList= new List<Asignatura>{
//                        new Asignatura
//                         {
//                             Name = "Matemáticas",
//                             CursoId=curso.Id,
//                             Id = Guid.NewGuid().ToString()
//                         },
//                         new Asignatura
//                         {
//                             Name = "Educación Física",
//                             CursoId=curso.Id,
//                             Id = Guid.NewGuid().ToString()
//                         },
//                         new Asignatura
//                         {
//                             Name = "Castellano",
//                             CursoId=curso.Id,
//                             Id = Guid.NewGuid().ToString()
//                         },
//                         new Asignatura
//                         {
//                             Name = "Ciencias Naturales",
//                             CursoId=curso.Id,
//                             Id = Guid.NewGuid().ToString()
//                         }
//                   };
//                 listaCompleta.AddRange(tempList);
//                 // curso.Asignaturas = tempList;
//             }
//             return listaCompleta;
//         }

//         private static List<Curso> CargarCursos(Escuela escuela)
//         {
//             return new List<Curso>(){
//                 new Curso(){Id=Guid.NewGuid().ToString(),
//                 EscuelaId=escuela.Id,
//                 Name="101",
//                 Jornada=TiposJornada.Mañana},
//                 new Curso(){Id=Guid.NewGuid().ToString(),
//                 EscuelaId=escuela.Id,
//                 Name="201",
//                 Jornada=TiposJornada.Mañana},
//                 new Curso(){Id=Guid.NewGuid().ToString(),
//                 EscuelaId=escuela.Id,
//                 Name="301",
//                 Jornada=TiposJornada.Mañana},
//                 new Curso(){Id=Guid.NewGuid().ToString(),
//                 EscuelaId=escuela.Id,
//                 Name="401",
//                 Jornada=TiposJornada.Tarde},
//                 new Curso(){Id=Guid.NewGuid().ToString(),
//                 EscuelaId=escuela.Id,
//                 Name="501",
//                 Jornada=TiposJornada.Tarde}
//             };
//         }

//         private List<Alumno> CargarAlumnos(List<Curso> cursos)
//         {
//             var listaAlumnos = new List<Alumno>();

//             Random rnd = new Random();
//             foreach (var curso in cursos)
//             {
//                 int cantRandom = rnd.Next(5, 20);
//                 var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
//                 listaAlumnos.AddRange(tmplist);
//             }
//             return listaAlumnos;
//         }
//         private List<Alumno> GenerarAlumnosAlAzar(
//             Curso curso,
//             int cantidad)
//         {
//             string[] Name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
//             string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
//             string[] Name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

//             var listaAlumnos = from n1 in Name1
//                                from n2 in Name2
//                                from a1 in apellido1
//                                select new Alumno { 
//                                 CursoId=curso.Id,   
//                                 Name = $"{n1} {n2} {a1}",
//                                 Id=Guid.NewGuid().ToString() };

//             return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
//         }

//     }
// }