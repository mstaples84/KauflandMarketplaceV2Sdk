namespace KauflandMarketplaceV2Sdk.RequestHelpers;

public interface IRequestBuilder
{
    HttpRequestMessage Build(HttpMethod method, string uriString, string? requestBody);
}