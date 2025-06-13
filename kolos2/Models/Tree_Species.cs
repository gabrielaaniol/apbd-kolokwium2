namespace kolos2.Models;

public class Tree_Species
{
    public int SpeciesId { get; set; }
    public string LatinName { get; set; }
    public int GrowthTimeInYears { get; set; }
    
    ICollection<Seedling_Batch> Seedling_Batches { get; set; } = new List<Seedling_Batch>();
}