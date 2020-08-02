using System;
using Microsoft.AspNetCore.Mvc;
using holaMundo.Models;
namespace holaMundo.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela("Camacho's School", 2005);
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Country = "Perú";
            escuela.City="Lima";
            escuela.Direction="Jr. Cerro Prieto 118";
            
            ViewBag.CosaDinamica = "La Monja";

            return View(escuela);
        }
    }
}