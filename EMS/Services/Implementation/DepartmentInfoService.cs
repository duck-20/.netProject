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
                        DepartmentId = item.DepartmentId,
                        DepartmentName=item.DepartmentName,
                        DeletedBy=item.DeletedBy,
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
            departmentInfo.DepartmentName = model.DepartmentName;
            departmentInfo.CreatedBy = 1;
            departmentInfo.CreatedDate= DateTime.Now;
            _connect.Add(departmentInfo);
            _connect.SaveChanges();

        }
        public void deleteDepartmentId(string departmentName)
        {
            var data = _connect.SetupDepartment.FirstOrDefault(x => x.DepartmentName== departmentName);
            if( data != null )
            {
                data.DeletedBy=1;
                data.DeletedDate= DateTime.Now;
            }
            _connect.SaveChanges();
        }
        public void UpdateDepartmentId(SetUpDepartmentViewModel model)
        {
            var data= _connect.SetupDepartment.FirstOrDefault(x=>x.DepartmentId== model.DepartmentId);
            if( data != null )
            {
                data.DepartmentName= model.DepartmentName;
                data.UpdatedBy=1;
                data.UpdatedDate= DateTime.Now;
            }
            _connect.SaveChanges();
        }
        
    }
}
