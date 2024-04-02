using EMS.Models;

namespace EMS.Services.Interface
{
    public interface IDepartmentInfo
    {
        List<SetUpDepartmentViewModel> SetupDepartmentList();
        int getDepartmentById(int departmentId);
        void saveDepartmentId(SetUpDepartmentViewModel model);
        void deleteDepartmentId(string departmentName);
        void UpdateDepartmentId(SetUpDepartmentViewModel model);
    }
}
