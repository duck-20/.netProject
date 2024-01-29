using EMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SetUpDepartmentViewModel model)
        {
            return View();
        }
    }
}
