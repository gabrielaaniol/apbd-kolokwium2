namespace kolos2.Models;

public class Seedling_Batch
{
    public int BatchId { get; set; }
    public int NurseryId { get; set; }
    public int SpeciesId { get; set; }
    public int Quantity { get; set; }
    public DateTime SownDate { get; set; }
    public DateTime ReadyDate { get; set; }
    
    ICollection<Responsible> Responsibles { get; set; } = new List<Responsible>();
    public Nursery Nursery { get; set; } = null!;
    public Responsible Responsible { get; set; } = null!;
}