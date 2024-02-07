using EMS.Models;
using EMS.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly IEmployeeInfo _EmployeeInfo;
        public EmployeeController(IEmployeeInfo IEmployeeInfo)
        {
            _EmployeeInfo = IEmployeeInfo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeInfoViewModel model)
        {
            var result = _EmployeeInfo;
            result.saveEmployeeId(model);
            return View();
        }

    }
}
