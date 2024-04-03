using EMS.ConnectionStrings;
using EMS.Entities;
using EMS.Models;
using EMS.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace EMS.Services.Implementation
{
    public class EmployeeInfoService : IEmployeeInfo
    {
        private readonly DbConnect _connect;
        public EmployeeInfoService(DbConnect connect)
        {
            _connect = connect;
        }
        public EmployeeInfoViewModel GetEmployeeById(int employeeId)
        {
            var data=_connect.Employees.First(x=>x.Id == employeeId);
            EmployeeInfoViewModel employeeInfo = new EmployeeInfoViewModel();
            employeeInfo.Id = data.Id;
            employeeInfo.FirstName = data.FirstName;
            employeeInfo.LastName = data.LastName;
            employeeInfo.Email = data.Email;
            employeeInfo.Address = data.Address;
            employeeInfo.PhoneNumber = data.PhoneNumber;
            employeeInfo.Gender = data.Gender;
            employeeInfo.ProfilePath = data.ProfilePath;
            return employeeInfo;

        }
        public void SaveEmployeeId(EmployeeInfoViewModel model)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo();
            employeeInfo.FirstName = model.FirstName;
            employeeInfo.LastName = model.LastName;    
            employeeInfo.Email = model.Email;
            employeeInfo.Address = model.Address;
            employeeInfo.PhoneNumber = model.PhoneNumber;
            employeeInfo.Gender = model.Gender;
            employeeInfo.ProfilePath = model.ProfilePath;
            employeeInfo.CreatedBy = 1;
            employeeInfo.CreatedDate = DateTime.Now;
            _connect.Add(employeeInfo);
            _connect.SaveChanges();


        }
        public void DeleteEmployeeId(int ID)
        {
            var data=_connect.Employees.FirstOrDefault(x=>x.Id==ID);
            if(data != null)
            {
                data.DeletedBy = 1;
                data.DeletedDate= DateTime.Now;
            }
            _connect.SaveChanges();
        }

        public List<EmployeeInfoViewModel> GetEmployeeList()
        {
            var data=_connect.Employees.ToList();
            var employeeList= new List<EmployeeInfoViewModel>();    
            if(data.Count > 0)
            {
                foreach(var employee in data)
                {
                    employeeList.Add(new EmployeeInfoViewModel()
                    {
                        Id = employee.Id,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Email = employee.Email,
                        Address = employee.Address,
                        PhoneNumber = employee.PhoneNumber,
                        Gender = employee.Gender,
                        ProfilePath = employee.ProfilePath,
                        DeletedBy= employee.DeletedBy,
                        UpdatedBy= employee.UpdatedBy,
                        CreatedBy= employee.CreatedBy,
                        DeletedDate= employee.DeletedDate,
                        UpdatedDate= employee.UpdatedDate,
                        CreatedDate= employee.CreatedDate,
                    });
                }
            }
            return employeeList;
        }
        public void UpdateEmployeeId(EmployeeInfoViewModel model)
        {
            var data=_connect.Employees.FirstOrDefault(x=>x.Id == model.Id);
            if(data != null)
            {
				data.FirstName = model.FirstName;
				data.LastName = model.LastName;
				data.Email = model.Email;
				data.Address = model.Address;
				data.PhoneNumber = model.PhoneNumber;
				data.Gender = model.Gender;
				data.ProfilePath = model.ProfilePath;
				data.UpdatedDate = model.UpdatedDate;
				data.UpdatedBy = 1;
			}
            _connect.Update(data);
            _connect.SaveChanges();
        }
	}
}
