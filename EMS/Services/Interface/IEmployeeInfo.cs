using EMS.Models;

namespace EMS.Services.Interface
{
    public interface IEmployeeInfo
    {
        List<EmployeeInfoViewModel> getEmployeeList();
        int getEmployeeById(int employeeId);
        void saveEmployeeId(EmployeeInfoViewModel model);
        void deleteEmployeeId(int employeeId);
    }
}
