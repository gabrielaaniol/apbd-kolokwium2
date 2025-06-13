namespace kolos2.Models;

public class Nursery
{
    public int NurseryId { get; set; }
    public string Name { get; set; }
    public DateTime EstablishedDate { get; set; }
    
    ICollection<Seedling_Batch> Seedling_Batches { get; set; } = new List<Seedling_Batch>();
    public IEnumerable<Seedling_Batch>? Seedlings { get; set; }
}