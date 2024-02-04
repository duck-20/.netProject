using EMS.Models;
using EMS.Services.Interface;

namespace EMS.Services.Implementation
{
    public class EmployeeInfoService : IEmployeeInfo
    {
        public int getEmployeeById(int employeeId)
        {
            return 1;
        }
        public void saveEmployeeId(EmployeeInfoViewModel model)
        {
            EmployeeInfoViewModel employeeInfoViewModel = new EmployeeInfoViewModel();
            employeeInfoViewModel.FirstName = model.FirstName;
            employeeInfoViewModel.LastName = model.LastName;    
            employeeInfoViewModel.Email = model.Email;
            employeeInfoViewModel.Address = model.Address;
            employeeInfoViewModel.PhoneNumber = model.PhoneNumber;
            employeeInfoViewModel.Gender = model.Gender;
            employeeInfoViewModel.ProfilePath = model.ProfilePath;


        }
        public void deleteEmployeeId(int employeeId)
        {

        }
    }
}
