using EMS.ConnectionStrings;
using EMS.Entities;
using EMS.Models;
using EMS.Services.Interface;

namespace EMS.Services.Implementation
{
    public class DepartmentInfoService:IDepartmentInfo
    {
        private readonly DbConnect _connect;
        public DepartmentInfoService(DbConnect connect)
        {
            _connect = connect;
        }
        public List<SetUpDepartmentViewModel> SetupDepartmentList()
        {
            var data=_connect.SetupDepartment.ToList();
            SetUpDepartmentViewModel viewModel = new SetUpDepartmentViewModel();
            var departmentList= new List<SetUpDepartmentViewModel>();
            if(data.Count > 0 )
            {
                foreach( var item in data )
                {
                    departmentList.Add(new SetUpDepartmentViewModel()
                    {
                        DeptName=item.DepartmentName,
                    });
                }
            }
            return departmentList;
            

            

        }
        public int getDepartmentById(int departmentId)
        {

            return 1;
        }
        public void saveDepartmentId(SetUpDepartmentViewModel model)
        {
            DepartmentInfo departmentInfo = new DepartmentInfo();
            departmentInfo.DepartmentName = model.DeptName;
            _connect.Add(departmentInfo);
            _connect.SaveChanges();

        }
        public void deleteDepartmentId(string departmentName)
        {
            var data=_connect.SetupDepartment.Where(x=>x.DepartmentName==departmentName).FirstOrDefault();
            _connect.Remove(data);
            _connect.SaveChanges();
        }
    }
}
