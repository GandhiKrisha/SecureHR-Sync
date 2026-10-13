namespace SecureHRSync.Api.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string EmployeeNumber { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public DateTime StartDate { get; set; }

        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public int DepartmentID { get; set; }

        public Department Department { get; set; } = null!;
        public string JobTitle { get; set;} = string.Empty;


    }
}