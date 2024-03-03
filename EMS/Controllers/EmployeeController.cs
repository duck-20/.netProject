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
        [HttpGet]
        public IActionResult DisplayData()
        {
            EmployeeInfoViewModel employeeInfoViewModel = new EmployeeInfoViewModel();
            var data=_EmployeeInfo.getEmployeeList();
            employeeInfoViewModel.Employees = data;
            return View(employeeInfoViewModel);
        }
        public IActionResult Edit(string phoneNumber)
        {
            var data = _EmployeeInfo.getEmployeeList();
            EmployeeInfoViewModel model = new EmployeeInfoViewModel();
            model = data.Where(info => info.PhoneNumber==phoneNumber).FirstOrDefault();
            return View(model);
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
