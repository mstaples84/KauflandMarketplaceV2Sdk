namespace KauflandMarketplaceV2Sdk.Models.Shared;

public class BasicErrorResponse
{
    public IEnumerable<FieldMessage> Errors { get; set; }
    public string Message { get; set; }
}