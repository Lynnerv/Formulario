using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Formulario.Models;

namespace Formulario.Controllers
{
    public class CursoController : Controller
    {
        private readonly ILogger<CursoController> _logger;

        public CursoController(ILogger<CursoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Curso curso)
        {
        // Validación de Costo por Crédito
        if (ModelState.IsValid)
            {
        // Calcula el costo total del curso
        double costoTotal = curso.Creditos * 100; // Cada crédito cuesta 100

        // Puedes pasar el costo total como ViewData para mostrarlo en la vista
        ViewData["CostoTotal"] = costoTotal;

        // Aquí podrías guardar el curso en la base de datos u otra lógica de negocio
        
        return View("Index", curso); // Vista que muestra el curso creado en este caso q esta index 
            }
        else
            {
         // Si el modelo no es válido, vuelve a mostrar el formulario de creación con errores
        return View("Index", curso);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
}
}

