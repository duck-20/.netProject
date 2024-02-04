using EMS.Models;

namespace EMS.Services.Interface
{
    public interface IEmployeeInfo
    {
        int getEmployeeById(int employeeId);
        void saveEmployeeId(EmployeeInfoViewModel model);
        void deleteEmployeeId(int employeeId);
    }
}
