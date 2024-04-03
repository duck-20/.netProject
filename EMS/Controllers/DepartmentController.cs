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
        public IActionResult Delete(int departmentId)
        {
            var data = _DepartmentInfo;
            data.deleteDepartmentId(departmentId);
            return RedirectToAction("DisplayData");
        }
        [HttpGet]
        public IActionResult Details(int departmentId)
        {
            var data = _DepartmentInfo.getDepartmentById(departmentId);
            return View(data);
        }
        [HttpGet]
        public IActionResult DisplayData()
        {
            var data = _DepartmentInfo.SetupDepartmentList();
            SetUpDepartmentViewModel setUpDepartmentViewModel = new SetUpDepartmentViewModel();
            setUpDepartmentViewModel.DeptList=data.Where(x=>x.DeletedDate==null).ToList();
            return View(setUpDepartmentViewModel);
        }
        [HttpGet]
        public IActionResult Edit(int departmentId)
        {
            var data = _DepartmentInfo.getDepartmentById(departmentId);
            return View(data);
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
