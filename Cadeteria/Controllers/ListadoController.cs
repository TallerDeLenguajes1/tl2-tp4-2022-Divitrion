using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadeteria.Models;

namespace Cadeteria.Controllers
{
    [Route("[controller]")]
    public class ListadoController : Controller
    {
        private readonly ILogger<ListadoController> _logger;
        private static List<Cadete> listadoCadetes = new List<Cadete>();
        public ListadoController(ILogger<ListadoController> logger)
        {
            _logger = logger;
        }

        [HttpPost]

        public IActionResult PostMethod(string nombre)
        {
            var cadete = new Cadete();
            cadete.nombre = @Request.Form["nombre"];
            listadoCadetes.Add(cadete);
            return View("Listado",listadoCadetes);
        }

        public IActionResult Listado()
        {
            return View(listadoCadetes);
        }

    }
}