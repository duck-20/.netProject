using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    public class EmployeeInfoViewModel
    {
        [Required(ErrorMessage ="*Please Enter Your FirstName!")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "*Please Enter Your LastName!")]
        public string LastName { get; set;} = string.Empty;
        [Required(ErrorMessage = "*Please Enter Your E-mail!")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "*Please Enter Your PhoneNumber!")]
        public string PhoneNumber { get; set; }=string.Empty;
        [Required(ErrorMessage = "*Please Enter Your Address!")]
        public string Address { get; set; } = string.Empty;
        [Required(ErrorMessage = "*Please Select a Gender!")]
        public int? Gender { get; set; }
        public string ProfilePath {  get; set; } = string.Empty;
        public List<EmployeeInfoViewModel> Employees { get; set; }
        public EmployeeInfoViewModel()
        {
            Employees = new List<EmployeeInfoViewModel>();
        }


    }
}
