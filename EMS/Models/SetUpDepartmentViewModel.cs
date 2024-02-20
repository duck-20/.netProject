using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class SetUpDepartmentViewModel
    {
        public int? DeptId {  get; set; }
        [Required]
        public string DeptName { get; set; } = string.Empty;
        public List<SetUpDepartmentViewModel> DeptList { get; set; }
        public SetUpDepartmentViewModel() {
        DeptList = new List<SetUpDepartmentViewModel>();
        }
    }
}
