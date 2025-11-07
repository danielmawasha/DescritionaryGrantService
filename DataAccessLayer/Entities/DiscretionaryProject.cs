namespace DataAccessLayer.Entities;

public class DiscretionaryProject
{
    public int OrganisationId { get; set; }
    public int ProjectStatusID { get; set; }
    public DateTime? ProjectStatDte { get; set; }
    public string ProjShortNam { get; set; }=string.Empty;
    public string ProjectNam { get; set; }=string.Empty;
    public int GrantWindowId { get; set; }
    public int WindowParamId { get; set; }
    public int ProjectTypeId { get; set; }
    public int SubmittedBy { get; set; }
    public DateTime? SubmissionDte { get; set; }
    public decimal TotInitReq { get; set; }
    public decimal TotProj { get; set; }
    public decimal TotReq { get; set; }
    public decimal TotFund { get; set; }
    public decimal TotExpend { get; set; }
    public decimal TotRcvd { get; set; }
    public decimal TotDisb { get; set; }
    public decimal TotGrant { get; set; }
    public int ProjMgrID { get; set; }
    public string Auditor { get; set; }
    public Int16 AuditYyIncl { get; set; }
    public string POAppr { get; set; }=string.Empty;
    public DateTime? POApprDte { get; set; }
    public string POApprNote { get; set; }=string.Empty;
    public string FinAppr { get; set; }
    public DateTime? FinApprDte { get; set; }
    public string FinApprNote { get; set; }=string.Empty;
    public string Reference { get; set; }=string.Empty;
    public string FileLoctn { get; set; }=string.Empty;
    public string PhotoLoctn { get; set; }=string.Empty;
    public DateTime? CaptureDte { get; set; }
    public Int16 NextLogNum { get; set; }
    public Boolean ArchiveYN { get; set; }
    public DateTime? ArchSetDte { get; set; }
    public string AppRef { get; set; }=string.Empty;
    public string CRPath { get; set; }=string.Empty;
    public string GISLong { get; set; }=string.Empty;
    public string GISLat { get; set; }=string.Empty;
    public DateTime? DteUpd { get; set; }
    public string UsrUpd { get; set; }=string.Empty;
    public DateTime? DteCreated { get; set; }
    public decimal TotOwnCntrb { get; set; }
    public decimal TotAddFund { get; set; }
    public int? RSAId { get; set; }
    public int? RSAAssignedBy { get; set; }
    public DateTime? RSAAssignDate { get; set; }
    public int? RegManagerId { get; set; }
}
