using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using holaMundo.Models;

namespace holaMundo.Controllers
{
    public class AsignaturaController : Controller
    {
        // public IActionResult Index()
        // {
        //     // var asignatura=new Asignatura{
        //     //     asignaturaId=GuasignaturaId.NewGuasignaturaId().ToString(),
        //     //     Name="Programación"
        //     // };
            
        //     return View(_context.Asignaturas.FirstOrDefault());
        // }

        // public IActionResult Index()
        // {
        //     var listaAsignaturas = new List<Asignatura>(){
        //                 new Asignatura{Name="Matemáticas",
        //                 UniqueasignaturaId=GuasignaturaId.NewGuasignaturaId().ToString()} ,
        //                 new Asignatura{Name="Educación Física",
        //                 UniqueasignaturaId=GuasignaturaId.NewGuasignaturaId().ToString()},
        //                 new Asignatura{Name="Castellano",
        //                 UniqueasignaturaId=GuasignaturaId.NewGuasignaturaId().ToString()},
        //                 new Asignatura{Name="Ciencias Naturales",
        //                 UniqueasignaturaId=GuasignaturaId.NewGuasignaturaId().ToString()}
        //     };
        //     ViewBag.CosaDinamica = "La Monja";
        //     ViewBag.Fecha=DateTime.Now;
        //     ViewBag.simple=new List<int>(){1,2,3,5};
        //     return View("MultiAsignatura",listaAsignaturas);
        // }
        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId?}")]
        public IActionResult Index(string asignaturaId){
            
            if(!string.IsNullOrWhiteSpace(asignaturaId)){
                var asignatura=from asig in _context.Asignaturas
                where asig.Id==asignaturaId
                select asig;
    
                return View(asignatura.SingleOrDefault());
            }else{
                return View("MultiAsignatura",_context.Asignaturas);
            }
        }

        public IActionResult MultiAsignatura(string asignaturaId)
        {
            return View("MultiAsignatura",_context.Asignaturas);
        }

        private EscuelaContext _context;

        public AsignaturaController(EscuelaContext context){
            _context=context;
        }
    }
}