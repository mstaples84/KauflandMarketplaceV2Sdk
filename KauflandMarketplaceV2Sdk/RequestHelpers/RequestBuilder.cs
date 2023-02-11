using System.Security.Cryptography;
using System.Text;

namespace KauflandMarketplaceV2Sdk.RequestHelpers;

/// <summary>
/// Builds the necessary Header for Requests using the configuration
/// </summary>
public class RequestBuilder : IRequestBuilder
{
    private readonly string _keyString;
    private readonly string _shopClientKey;
    
    public RequestBuilder()
    {
        // Todo add configuration
        _keyString = "a7d0cb1da1ddbc86c96ee5fedd341b7d8ebfbb2f5c83cfe0909f4e57f05dd403";
        _shopClientKey = "7bffc16ba2cc5ac1cbf527d6fa39263";
    }

    public HttpRequestMessage Build(HttpMethod method, string uriString, string? requestBody)
    {
        requestBody ??= string.Empty;
        var request = new HttpRequestMessage(method, uriString);
        
        // add headers
        AddHeaders(request, requestBody);

        request.Content = new StringContent(requestBody);
        
        return request;
    }

    private void AddHeaders(HttpRequestMessage requestMessage, string requestBody)
    {
        var now = DateTimeOffset.UtcNow;
        var unixTimeSeconds = now.ToUnixTimeSeconds().ToString();
        var methodString = requestMessage.Method.ToString().ToUpper();
        var uriString = requestMessage.RequestUri?.ToString() ?? string.Empty;
        var signedString = CreateToken($"{methodString}{uriString}{requestBody}{unixTimeSeconds}");

        requestMessage.Headers.Add("Shop-Client-Key", _shopClientKey);
        requestMessage.Headers.Add("Accept", "application/json");
        requestMessage.Headers.Add("Shop-Timestamp", unixTimeSeconds);
        requestMessage.Headers.Add("Shop-Signature", signedString);
        requestMessage.Headers.Add("User-Agent", ".NET Kaufland Seller API SDK");
    }
    
    private string CreateToken(string message)
    {
        var secret = _keyString ?? "";
        var encoding = new ASCIIEncoding();
        var keyByte = encoding.GetBytes(secret);
        var messageBytes = encoding.GetBytes(message);
        using (var hmacsha256 = new HMACSHA256(keyByte))
        {
            var hashmessage = hmacsha256.ComputeHash(messageBytes);
            return Convert.ToBase64String(hashmessage);
        }
    }
}