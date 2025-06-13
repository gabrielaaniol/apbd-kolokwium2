namespace kolos2.Models;

public class Responsible
{
    public int BatchId { get; set; }
    public int Employee { get; set; }
    public string Role { get; set; }
    
    public Seedling_Batch Seedling_Batch { get; set; } = null!;
    public Employee Employee1 { get; set; } = null!;
}