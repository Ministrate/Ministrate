namespace Ministrate.Platform.Domain.Common;

public class BaseEntity
{
    public int Id { get; set; }
    
    public DateTimeOffset? DateCreated { get; set; }
    public string? CreatedByName { get; set; }
    public int? CreatedBy { get; set; }
    
    public DateTimeOffset? DateModified { get; set; }
    public string? ModifiedByName { get; set; }
    public int? ModifiedBy { get; set; }
}