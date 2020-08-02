using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using holaMundo.Models;

namespace holaMundo.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            var alumno=new Alumno{
                UniqueId=Guid.NewGuid().ToString(),
                Name="Programación"
            };
            
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha=DateTime.Now;
            ViewBag.simple=new List<int>(){1,2,3,5};
            return View(alumno);
        }

        // public IActionResult Index()
        // {
        //     var listaAlumnos = new List<alumno>(){
        //                 new alumno{Name="Matemáticas",
        //                 UniqueId=Guid.NewGuid().ToString()} ,
        //                 new alumno{Name="Educación Física",
        //                 UniqueId=Guid.NewGuid().ToString()},
        //                 new alumno{Name="Castellano",
        //                 UniqueId=Guid.NewGuid().ToString()},
        //                 new alumno{Name="Ciencias Naturales",
        //                 UniqueId=Guid.NewGuid().ToString()}
        //     };
        //     ViewBag.CosaDinamica = "La Monja";
        //     ViewBag.Fecha=DateTime.Now;
        //     ViewBag.simple=new List<int>(){1,2,3,5};
        //     return View("Multialumno",listaAlumnos);
        // }

        public IActionResult MultiAlumno()
        {
            // var listaAlumnos = new List<Alumno>(){
            //             new Alumno{Name="Aldhair Vera",
            //             UniqueId=Guid.NewGuid().ToString()} ,
            //             new Alumno{Name="Nalgancy Rojas",
            //             UniqueId=Guid.NewGuid().ToString()},
            //             new Alumno{Name="Pio Jr. 1, el fuerte",
            //             UniqueId=Guid.NewGuid().ToString()},
            //             new Alumno{Name="Pio Jr. 2, la amarillita",
            //             UniqueId=Guid.NewGuid().ToString()}
            // };
            var listaAlumnos =new List<Alumno>();
            listaAlumnos=GenerarAlumnosAlAzar();
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.CantidadAlumno=listaAlumnos.Count;
            ViewBag.Fecha=DateTime.Now;
            ViewBag.simple=new List<int>(){1,2,3,5};
            return View("Multialumno",listaAlumnos);
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
                               UniqueId=Guid.NewGuid().ToString() };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}