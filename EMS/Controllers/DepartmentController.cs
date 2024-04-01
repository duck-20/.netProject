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
        public readonly DbConnect _connect;
        public DepartmentController(DbConnect dbConnect, IDepartmentInfo departmentInfo)
        {
            _connect = dbConnect;
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
        public IActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(string deptName)
        {
            var data = _DepartmentInfo.SetupDepartmentList();
            SetUpDepartmentViewModel setUpDepartmentViewModel = new SetUpDepartmentViewModel();
            setUpDepartmentViewModel = data.Where(x => x.DeptName == deptName).FirstOrDefault();
            return View(setUpDepartmentViewModel);
        }
        [HttpGet]
        public IActionResult DisplayData()
        {
            var data = _DepartmentInfo.SetupDepartmentList();
            SetUpDepartmentViewModel setUpDepartmentViewModel = new SetUpDepartmentViewModel();
            setUpDepartmentViewModel.DeptList = data;
            return View(setUpDepartmentViewModel);
        }
        public IActionResult Edit(string deptName)
        {
            var data = _DepartmentInfo.SetupDepartmentList();
            SetUpDepartmentViewModel setUpDepartmentViewModel = new SetUpDepartmentViewModel();
            setUpDepartmentViewModel = data.Where(x => x.DeptName == deptName).FirstOrDefault();
            return View(setUpDepartmentViewModel);
        }
        [HttpPost]
        public IActionResult Create(SetUpDepartmentViewModel model)
        {
            var result = _DepartmentInfo;
            result.saveDepartmentId(model);
            return View();
        }
        [HttpPost]
        public IActionResult Edit(SetUpDepartmentViewModel model)
        {
            return RedirectToAction("DisplayData");

        }
    }
}
