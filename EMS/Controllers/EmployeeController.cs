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
        public IActionResult Delete()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var data=_EmployeeInfo.GetEmployeeById(Id);
            return View(data);
        }
        [HttpGet]
        public IActionResult DisplayData()
        {
            EmployeeInfoViewModel employeeInfoViewModel = new EmployeeInfoViewModel();
            var data=_EmployeeInfo.GetEmployeeList();
            employeeInfoViewModel.Employees = data.Where(x=>x.DeletedDate==null).ToList();
            return View(employeeInfoViewModel);
        }
        [HttpGet]   
        public IActionResult Edit(int Id)
        {
            var data=_EmployeeInfo.GetEmployeeById(Id);
            return View(data);

        }
        [HttpPost]
        public IActionResult Edit(EmployeeInfoViewModel model) 
        {
            var data = _EmployeeInfo;
            data.UpdateEmployeeId(model);
            return RedirectToAction("DisplayData");
        }
        [HttpGet]
        public IActionResult Delete(int Id) 
        {
            var data = _EmployeeInfo;
            data.DeleteEmployeeId(Id);
            return RedirectToAction("DisplayData");
        }
        [HttpPost]
        public IActionResult Create(EmployeeInfoViewModel model)
        {
            var result = _EmployeeInfo;
            result.SaveEmployeeId(model);
            return View();
        }

    }
}
