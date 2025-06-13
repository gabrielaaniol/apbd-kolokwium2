namespace kolos2.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }

    public ICollection<Responsible> Responsibles { get; set; } = new List<Responsible>();
}