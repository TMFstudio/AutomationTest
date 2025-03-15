using Newtonsoft.Json;
using RestSharp;

namespace EPShope.Services
{
    public class ApiHelper : IApiHelper
    {
        public virtual async Task<RestResponse<T>> RestsharpAsync<T>(
            string baseUrl,
            string webServiceAddress,
            Method methodType,
            object body = null,
            bool addToken = false
            )
        {
            ArgumentException.ThrowIfNullOrEmpty(baseUrl);
            ArgumentException.ThrowIfNullOrEmpty(webServiceAddress);

            var options = new RestClientOptions(baseUrl)
            {
                MaxTimeout = -1
            };
            var client = new RestClient(options);
            var request = new RestRequest(webServiceAddress, methodType);
         
            if (body != null)
                request.AddStringBody(JsonConvert.SerializeObject(body), DataFormat.Json);

            var response = await client.ExecuteAsync<T>(request);
            return response;
        }

    }

}