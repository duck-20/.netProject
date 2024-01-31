using EMS.Models;

namespace EMS.Services.Interface
{
    public interface IDepartmentInfo
    {
        int getDepartmentById(int departmentId);
        void saveDepartmentId(SetUpDepartmentViewModel model);
        void deleteDepartmentId(int departmentId);
    }
}
