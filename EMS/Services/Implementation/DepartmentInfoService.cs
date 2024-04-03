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
                        DeletedDate=item.DeletedDate,
                        CreatedDate=item.CreatedDate,
                        CreatedBy=item.CreatedBy,
                        UpdatedDate=item.UpdatedDate,
                        UpdatedBy=item.UpdatedBy,
                    });
                }
            }
            return departmentList;
        }
        public SetUpDepartmentViewModel getDepartmentById(int departmentId)
        {
            var data=_connect.SetupDepartment.First(x=>x.DepartmentId == departmentId);
            SetUpDepartmentViewModel result = new SetUpDepartmentViewModel();
            result.DepartmentId = data.DepartmentId;
            result.DepartmentName = data.DepartmentName;
            return result;
            
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
        public void deleteDepartmentId(int departmentID)
        {
            var data = _connect.SetupDepartment.FirstOrDefault(x => x.DepartmentId== departmentID);
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
            _connect.Update(data);
            _connect.SaveChanges();
        }
        
    }
}
