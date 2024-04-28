using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using turboazAzureHometask.Models;

namespace turboazAzureHometask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TurboazDbContext _dbcontext;

        public HomeController(ILogger<HomeController> logger, TurboazDbContext dbcontext)
        {
            _logger = logger;
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            var cars = _dbcontext.Cars.ToList();
            return View(cars);
        }



        [Route("get/{id:int?}")]
        public async Task<IActionResult> Get(int id)
        {
            var cars = await _dbcontext.Cars.FirstOrDefaultAsync(p => p.Id == id);

            if (cars == null)
            {
                return NotFound();
            }
            return View(cars);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
