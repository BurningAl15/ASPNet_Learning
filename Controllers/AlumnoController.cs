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
            return View(_context.Alumnos.FirstOrDefault());
        }

        public IActionResult MultiAlumno()
        {
            // var listaAlumnos =new List<Alumno>();
            // listaAlumnos=GenerarAlumnosAlAzar();
            // return View("Multialumno",_context.Alumnos.ToList());
            return View("Multialumno",_context.Alumnos);
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

        private EscuelaContext _context;

        public AlumnoController(EscuelaContext context){
            _context=context;
        }
    }
}