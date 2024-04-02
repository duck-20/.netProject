using EMS.Models;

namespace EMS.Services.Interface
{
    public interface IEmployeeInfo
    {
        List<EmployeeInfoViewModel> GetEmployeeList();
        int GetEmployeeById(int employeeId);
        void SaveEmployeeId(EmployeeInfoViewModel model);
        void DeleteEmployeeId(int ID);
        void UpdateEmployeeId(EmployeeInfoViewModel model);
    }
}
