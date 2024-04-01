using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Entities
{
    public class DepartmentInfo:BaseEntities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; } = string.Empty;
    }
}
