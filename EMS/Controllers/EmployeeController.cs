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
        public IActionResult Details(int ID)
        {
            var data=_EmployeeInfo.GetEmployeeList();
            EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
            viewModel = data.FirstOrDefault(info => info.Id==ID);
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult DisplayData()
        {
            EmployeeInfoViewModel employeeInfoViewModel = new EmployeeInfoViewModel();
            var data=_EmployeeInfo.GetEmployeeList();
            employeeInfoViewModel.Employees = data.Where(x=>x.DeletedBy==null).ToList();
            return View(employeeInfoViewModel);
        }
        [HttpGet]   
        public IActionResult Edit(int ID)
        {
            var data = _EmployeeInfo.GetEmployeeList();
            EmployeeInfoViewModel model = new EmployeeInfoViewModel();
            model = data.Where(info => info.Id == ID).FirstOrDefault();
            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(EmployeeInfoViewModel model) 
        {
            var data = _EmployeeInfo;
            data.UpdateEmployeeId(model);
            return RedirectToAction("DisplayData");
        }
        [HttpGet]
        public IActionResult Delete(int ID) 
        {
            var data = _EmployeeInfo;
            data.DeleteEmployeeId(ID);
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
