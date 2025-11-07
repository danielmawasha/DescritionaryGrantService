namespace DataAccessLayer.Entities;

public class DiscretionaryDetailApproval
{
    public int ApplicationId { get; set; }
    public int ApprovalTypeId { get; set; }
    public int ApprovalStatusId { get; set; }
    public string Comments { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; }
    public int UserId { get; set; }
    public DateTime DteUpd { get; set; }
    public int UserUpd { get; set; }
}
