using System.ComponentModel.DataAnnotations;

namespace EMS.Entities
{
    public class DepartmentInfo:BaseEntities
    {
        public int? DeptId { get; set; }
        [Required]
        public string DeptName { get; set; } = string.Empty;
        [Required]
        public int? DisplayOrder { get; set; }
    }
}
