namespace kolos2.DTOs;

public class ResponsibleDto
{
    //odpowoedzi z GET
    public int BatchId { get; set; }
    public int NurseryId { get; set; }
    public int SpeciesId { get; set; }
    public int Quantity { get; set; }
    public DateTime SownDate { get; set; }
    public DateTime ReadyDate { get; set; }
}