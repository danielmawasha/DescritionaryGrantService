namespace DataAccessLayer.Entities;

public class DiscretionaryStatus
{
    public int Status { get; set; }
    public string StatusDesc { get; set; } = string.Empty;
    public string Typ { get; set; } = string.Empty;
}
