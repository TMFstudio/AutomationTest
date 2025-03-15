using RestSharp;

namespace EPShope.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public virtual async Task<RestResponse<T>> RestSharpAsync<T>(
         string baseUrl,
         string webServiceAddress,
          Method methodType,
         object body = null,
         bool addToken = false
         )
        {
            ArgumentNullException.ThrowIfNull(webServiceAddress);
            ArgumentNullException.ThrowIfNull(baseUrl);
            var options = new RestClientOptions(baseUrl)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(webServiceAddress, methodType);
            request.AddHeader("Content-Type", "application/json");

            //if (addToken)
            //    request.AddHeader("Authorization", $"Bearer {token}");


            var response = await client.ExecuteAsync<T>(request);

            return response;
        }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
