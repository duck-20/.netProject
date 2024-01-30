using System.ComponentModel.DataAnnotations;

namespace EMS.Entities
{
    public class EmployeeInfo:BaseEntities
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public int? Gender { get; set; }
        public string ProfilePath { get; set; } = string.Empty;
    }
}
