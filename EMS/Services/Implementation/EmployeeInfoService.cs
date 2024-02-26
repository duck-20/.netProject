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
            EmployeeInfoViewModel model1 = new EmployeeInfoViewModel();
            EmployeeInfoViewModel model2 = new EmployeeInfoViewModel();
            var EmployeeList=new List<EmployeeInfoViewModel>();
            model1.FirstName = "Ayush";
            model1.LastName = "Pakhrin";
            model1.Email = "Pakhrinayush56@gmail.com";
            model1.Address = "Boudha";
            model1.PhoneNumber = "9813493440";
            model1.Gender = 1;
            EmployeeList.Add(model1);
            model2.FirstName = "Robina";
            model2.LastName = "Shahi";
            model2.Email = "shahirobina45@gmail.com";
            model2.Address = "Teku";
            model2.PhoneNumber = "9804774785";
            model2.Gender = 2;
            EmployeeList.Add(model2);
            return EmployeeList;
        }
    }
}
