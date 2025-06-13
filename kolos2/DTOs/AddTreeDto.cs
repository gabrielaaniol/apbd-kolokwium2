namespace kolos2.DTOs;

public class AddTreeDto
{
    //do przyjmowania drzew POST
    
    public string LatinName { get; set; }
    public int GrowthTimeInYears { get; set; }

    private List<SchoolInfoDto> SchoolInfos { get; set; } = new();
}