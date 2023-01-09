using FastFoot.mvc.Interface;
using FastFoot.mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace FastFoot.mvc.Controllers
{
    public class AdminController : Controller
    {
        private readonly IFootInterface _footInterface;

        public AdminController(IFootInterface footInterface)
        {
            _footInterface = footInterface;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var allFoot = _footInterface.GetAllFoots();
            return View(allFoot);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Foot foot)
        {
            _footInterface.AddFoot(foot);
            return RedirectToAction("index");
        }
    }
}
