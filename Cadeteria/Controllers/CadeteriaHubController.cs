using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cadeteria.Models;

namespace Cadeteria.Controllers;

public class CadeteriaHubController : Controller
{
    private readonly ILogger<CadeteriaHubController> _logger;
    private static CadeteriaWeb cadeteria = new CadeteriaWeb();

    public CadeteriaHubController(ILogger<CadeteriaHubController> logger)
    {
        _logger = logger;
    }

    [HttpPost]

    public IActionResult Carga(string nombre)
    {
        cadeteria.AgregarCadete(Request.Form["Nombre"],Request.Form["Telefono"],Request.Form["Direccion"]);
        return Redirect("Listado");
    }

    [HttpGet]
    public IActionResult Borrar(int id)
    {
        cadeteria.RemoverCadete(id);
        return Redirect("listado");
    }

    public IActionResult Listado()
    {
        return View(cadeteria.ListadoCadetes);
    }

    public IActionResult AltaCadete()
    {
        return View();
    }

    public IActionResult BajaCadete()
    {
        return View(cadeteria.ListadoCadetes);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

