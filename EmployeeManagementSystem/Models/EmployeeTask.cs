namespace EmployeeManagementSystem.Models
{
    public class EmployeeTask
    {
     
        public int EmployeeId { get; set; }

        public int EmpTaskId { get; set; }

        public Employee Employee { get; set; }

        public EmpTask Task { get; set; }


    }
}
