using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class EmpTask
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskEnd { get; set; }
        public bool IsCompleted { get; set; }
        public ICollection<EmployeeTask> EmployeeTasks { get; set; }

    }
}
