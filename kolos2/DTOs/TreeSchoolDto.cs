namespace kolos2.DTOs;

public class TreeSchoolDto
{
    //lista w TreeSchool i AddTree
    public int SpeciesId { get; set; }
    public string LatinName { get; set; }
    public int GrowthTimeInYears { get; set; }
    
    public int BatchId { get; set; }
    public int NurseryId { get; set; }
    public int Quantity { get; set; }
    public DateTime SownDate { get; set; }
    public DateTime ReadyDate { get; set; }
}