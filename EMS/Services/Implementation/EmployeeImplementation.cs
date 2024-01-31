using EMS.Models;
using EMS.Services.Interface;

namespace EMS.Services.Implementation
{
    public class EmployeeImplementation : IEmployeeInfo
    {
        public int getEmployeeById(int employeeId)
        {
            return 1;
        }
        public void saveEmployeeId(CreateEmployeeViewModel model)
        {

        }
        public void deleteEmployeeId(int employeeId)
        {

        }
    }
}
