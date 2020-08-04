using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using holaMundo.Models;

namespace holaMundo.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura=new Asignatura{
                Id=Guid.NewGuid().ToString(),
                Name="Programación"
            };
            
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha=DateTime.Now;
            ViewBag.simple=new List<int>(){1,2,3,5};
            return View(asignatura);
        }

        // public IActionResult Index()
        // {
        //     var listaAsignaturas = new List<Asignatura>(){
        //                 new Asignatura{Name="Matemáticas",
        //                 UniqueId=Guid.NewGuid().ToString()} ,
        //                 new Asignatura{Name="Educación Física",
        //                 UniqueId=Guid.NewGuid().ToString()},
        //                 new Asignatura{Name="Castellano",
        //                 UniqueId=Guid.NewGuid().ToString()},
        //                 new Asignatura{Name="Ciencias Naturales",
        //                 UniqueId=Guid.NewGuid().ToString()}
        //     };
        //     ViewBag.CosaDinamica = "La Monja";
        //     ViewBag.Fecha=DateTime.Now;
        //     ViewBag.simple=new List<int>(){1,2,3,5};
        //     return View("MultiAsignatura",listaAsignaturas);
        // }

        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                        new Asignatura{Name="Matemáticas",
                        Id=Guid.NewGuid().ToString()} ,
                        new Asignatura{Name="Educación Física",
                        Id=Guid.NewGuid().ToString()},
                        new Asignatura{Name="Castellano",
                        Id=Guid.NewGuid().ToString()},
                        new Asignatura{Name="Ciencias Naturales",
                        Id=Guid.NewGuid().ToString()}
            };
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha=DateTime.Now;
            ViewBag.simple=new List<int>(){1,2,3,5};
            return View("MultiAsignatura",listaAsignaturas);
        }
    }
}