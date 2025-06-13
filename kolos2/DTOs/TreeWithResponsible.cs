namespace kolos2.DTOs;

public class TreeWithResponsible
{
    //lista w TreeSchool i AddTree
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }
    
    public List<ResponsibleDto> Responsibles { get; set; } = new();
}