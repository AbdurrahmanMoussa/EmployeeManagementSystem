namespace EmployeeManagementSystem.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public Employee OwningEmployee { get; set; }
    }
}
