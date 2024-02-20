using EMS.Models;
using EMS.Services.Interface;

namespace EMS.Services.Implementation
{
    public class DepartmentInfoService:IDepartmentInfo
    {
        public List<SetUpDepartmentViewModel> SetupDepartmentList()
        {
            SetUpDepartmentViewModel viewModel = new SetUpDepartmentViewModel();
            var departmentList = new List<SetUpDepartmentViewModel>();
            viewModel.DeptName = "BCA";
            departmentList.Add(viewModel);
            return departmentList;
            

        }
        public int getDepartmentById(int departmentId)
        {
            return 1;
        }
        public void saveDepartmentId(SetUpDepartmentViewModel model)
        {
            SetUpDepartmentViewModel setUpDepartmentViewModel = new SetUpDepartmentViewModel();
            setUpDepartmentViewModel.DeptName = model.DeptName;

        }
        public void deleteDepartmentId(int departmentId)
        {

        }
    }
}
