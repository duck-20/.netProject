using EMS.Entities;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class SetUpDepartmentViewModel:BaseEntities
    {
        public int? DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; } = string.Empty;
        public List<SetUpDepartmentViewModel> DeptList { get; set; }
        public SetUpDepartmentViewModel() {
        DeptList = new List<SetUpDepartmentViewModel>();
        }
    }
}
