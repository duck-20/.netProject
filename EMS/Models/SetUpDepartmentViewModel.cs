using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class SetUpDepartmentViewModel
    {
        public int? DeptId {  get; set; }
        [Required]
        public string DeptName { get; set; } = string.Empty;
    }
}
