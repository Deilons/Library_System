using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Library_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Library_System.Controllers
{
    [Route("[controller]")]
    public class DocumentTypesController : Controller
    {
        private readonly ILogger<DocumentTypesController> _logger;

        private readonly AplicationDbContext _context;

        public DocumentTypesController(ILogger<DocumentTypesController> logger, AplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        

        public IActionResult Index()
        {   
            var AlldocumentTypes = _context.DocumentTypes.ToList();
            _logger.LogInformation("Index");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("Error")]
        public IActionResult Error()
        {   
            return View("Error!");
        }
    }
}