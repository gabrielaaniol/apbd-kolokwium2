namespace kolos2.DTOs;

public class AddTreeDto
{
    //do przyjmowania drzew POST
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }

    private List<ResponsibleDto> SchoolInfos { get; set; } = new();
}