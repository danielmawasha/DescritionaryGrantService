namespace DataAccessLayer.Entities;

public class DiscretionaryTrancheBatch
{
    public string Description { get; set; } = string.Empty;
    public string BatchNumber { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; }
    public int UserId { get; set; }
    public DateTime? DteUpd { get; set; }
    public int? UsrUpd { get; set; }
}
