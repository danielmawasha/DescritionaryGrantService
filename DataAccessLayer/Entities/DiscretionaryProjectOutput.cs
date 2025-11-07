namespace DataAccessLayer.Entities;

public class DiscretionaryProjectOutput
{
    public string Title { get; set; }=string.Empty;
    public string ProjType { get; set; }=string.Empty;
    public string FocusArea { get; set; }=string.Empty;
    public string SubCategory { get; set; }=string.Empty;
    public int ProjectId { get; set; }
    public int ApplicationId { get; set; }
    public int OrganisationId { get; set; }
    public string ProjectStatus { get; set; } =string.Empty;
    public DateTime? ProjectStatDte { get; set; }
    public DateTime? ProjectEndDate { get; set; }
    public string ProjShortNam { get; set; } =string.Empty;
    public string ProjectNam { get; set; } =string.Empty;
    public DateTime? SubmissionDte { get; set; }
    public string SDLNo { get; internal set; } =string.Empty;
    public string Organisation_Name { get; internal set; } =string.Empty;
    public int SdfId { get; internal set; }
    public int? RSAId { get; internal set; }
    public int WindowId { get; internal set; }
    public DateTime? ContractStartDate { get; internal set; }
    public DateTime? ContractEndDate { get; internal set; }
}
