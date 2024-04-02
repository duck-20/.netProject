using EMS.ConnectionStrings;
using EMS.Entities;
using EMS.Models;
using EMS.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EMS.Controllers
{
    public class DepartmentController : Controller
    {
        public readonly IDepartmentInfo _DepartmentInfo;
        public DepartmentController( IDepartmentInfo departmentInfo)
        {
            _DepartmentInfo = departmentInfo;
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
        public IActionResult Delete(string departmentName)
        {
            var data = _DepartmentInfo;
            data.deleteDepartmentId(departmentName);
            return RedirectToAction("DisplayData");
        }
        [HttpGet]
        public IActionResult Details(string deptName)
        {
            var data = _DepartmentInfo.SetupDepartmentList();
            SetUpDepartmentViewModel setUpDepartmentViewModel = new SetUpDepartmentViewModel();
            setUpDepartmentViewModel = data.Where(x => x.DepartmentName == deptName).FirstOrDefault();
            return View(setUpDepartmentViewModel);
        }
        [HttpGet]
        public IActionResult DisplayData()
        {
            var data = _DepartmentInfo.SetupDepartmentList();
            SetUpDepartmentViewModel setUpDepartmentViewModel = new SetUpDepartmentViewModel();
            setUpDepartmentViewModel.DeptList=data.Where(x=>x.DeletedBy==null).ToList();
            return View(setUpDepartmentViewModel);
        }
        [HttpGet]
        public IActionResult Edit(string deptName)
        {
            var data = _DepartmentInfo.SetupDepartmentList();
            SetUpDepartmentViewModel setUpDepartmentViewModel = new SetUpDepartmentViewModel();
            setUpDepartmentViewModel = data.Where(x => x.DepartmentName == deptName).FirstOrDefault();
            return View(setUpDepartmentViewModel);
        }
        [HttpPost]
        public IActionResult Edit(SetUpDepartmentViewModel model)
        {
            var result = _DepartmentInfo;
            result.UpdateDepartmentId(model);
            return RedirectToAction("DisplayData");
        }
        [HttpPost]
        public IActionResult Create(SetUpDepartmentViewModel model)
        {
            var result = _DepartmentInfo;
            result.saveDepartmentId(model);
            return View();
        }
    }
}
