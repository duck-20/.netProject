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

        public List<EmployeeInfoViewModel> getEmployeeList()
        {
            EmployeeInfoViewModel model = new EmployeeInfoViewModel();
            var EmployeeList=new List<EmployeeInfoViewModel>();
            model.FirstName = "Ayush";
            model.LastName = "Pakhrin";
            model.Email = "Pakhrinayush56@gmail.com";
            model.Address = "Boudha";
            model.PhoneNumber = "9813493440";
            model.Gender = 1;
            EmployeeList.Add(model);
            model.FirstName = "Robina";
            model.LastName = "Shahi";
            model.Email = "shahirobina45@gmail.com";
            model.Address = "Teku";
            model.PhoneNumber = "9804774785";
            model.Gender = 2;
            EmployeeList.Add(model);
            return EmployeeList;
        }
    }
}
