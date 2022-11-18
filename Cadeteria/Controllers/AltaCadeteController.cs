using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cadeteria.Controllers
{
    [Route("[controller]")]
    public class AltaCadeteController : Controller
    {
        private readonly ILogger<AltaCadeteController> _logger;

        public AltaCadeteController(ILogger<AltaCadeteController> logger)
        {
            _logger = logger;
        }

        public IActionResult AltaCadete()
        {
            return View();
        }
    }
}