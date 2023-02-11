using DILifeCycle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DILifeCycle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonGuidGenerator singleton;
        private readonly ITransientGuidGenerator transient;
        private readonly IScopedGuidGenerator scoped;
        private readonly GuidService guidService;

        public HomeController(ILogger<HomeController> logger, ISingletonGuidGenerator singleton, ITransientGuidGenerator transient, IScopedGuidGenerator scoped, GuidService guidService)
        {
            _logger = logger;
            this.singleton = singleton;
            this.transient = transient;
            this.scoped = scoped;
            this.guidService = guidService;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = singleton.Guid.ToString();
            ViewBag.Transient = transient.Guid.ToString();
            ViewBag.Scoped = scoped.Guid.ToString();

            ViewBag.SingletonInService = guidService.Singleton.Guid.ToString();
            ViewBag.TransientInService = guidService.Transient.Guid.ToString();
            ViewBag.ScopedInService = guidService.Scoped.Guid.ToString();



            return View();
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