namespace SecureHRSync.Api.Models
{
    public class Department
{
    public int Id { get; set; }

    public string DepartmentCode { get; set; } = string.Empty;

    public string DepartmentName { get; set; } = string.Empty;
    public List<Employee> Employees { get; set; } = new();
    }
}