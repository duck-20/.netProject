﻿using EMS.Models;
using EMS.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    public class DepartmentController : Controller
    {
        public readonly IDepartmentInfo _DepartmentInfo;
        public DepartmentController(IDepartmentInfo departmentInfo)
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
    }
}
