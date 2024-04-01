using EMS.ConnectionStrings;
using EMS.Entities;
using EMS.Models;
using EMS.Services.Interface;

namespace EMS.Services.Implementation
{
    public class EmployeeInfoService : IEmployeeInfo
    {
        private readonly DbConnect _connect;
        public EmployeeInfoService(DbConnect connect)
        {
            _connect = connect;
        }
        public int getEmployeeById(int employeeId)
        {
            return 1;
        }
        public void saveEmployeeId(EmployeeInfoViewModel model)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo();
            employeeInfo.FirstName = model.FirstName;
            employeeInfo.LastName = model.LastName;    
            employeeInfo.Email = model.Email;
            employeeInfo.Address = model.Address;
            employeeInfo.PhoneNumber = model.PhoneNumber;
            employeeInfo.Gender = model.Gender;
            employeeInfo.ProfilePath = model.ProfilePath;
            _connect.Add(employeeInfo);
            _connect.SaveChanges();


        }
        public void deleteEmployeeId(int employeeId)
        {

        }

        public List<EmployeeInfoViewModel> getEmployeeList()
        {
            var data=_connect.Employees.ToList();
            var employeeList= new List<EmployeeInfoViewModel>();    
            if(data.Count > 0)
            {
                foreach(var employee in data)
                {
                    employeeList.Add(new EmployeeInfoViewModel()
                    {
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Email = employee.Email,
                        Address = employee.Address,
                        PhoneNumber = employee.PhoneNumber,
                        Gender = employee.Gender,
                        ProfilePath = employee.ProfilePath
                    });
                }
            }
            return employeeList;
        }
    }
}
