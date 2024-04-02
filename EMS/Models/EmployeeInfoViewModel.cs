using EMS.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    public class EmployeeInfoViewModel:BaseEntities
    {
		public int Id { get; set; }
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
		public List<EmployeeInfoViewModel> Employees { get; set; }
        public EmployeeInfoViewModel()
        {
            Employees = new List<EmployeeInfoViewModel>();
        }


    }
}
