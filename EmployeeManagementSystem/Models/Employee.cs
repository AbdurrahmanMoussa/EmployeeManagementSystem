using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required, MaxLength(25)]
        public string FirstName { get; set; }
        [Required, MaxLength(25)]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateLeft { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; } 
        public double Salary { get; set; }
        [Required]
        public Address Address { get; set; }

    /*    public Role Roles { get; set; }*/
        public ICollection<Phone> Phones { get; set; }
        public ICollection<EmployeeTask> EmployeeTasks { get; set; }


    }
}
