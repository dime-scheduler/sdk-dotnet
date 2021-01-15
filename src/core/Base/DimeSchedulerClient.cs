using System.IO;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerClient
    {
        public string Uri { get; private set; }
        public bool Authenticated => !string.IsNullOrEmpty(AuthenticationToken);
        public string AuthenticationToken { get; private set; }

        public DimeSchedulerClient(string uri)
        {
            Uri = uri;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task Authenticate(string userName, string password)
        {
            RestClient client = new(Path.Combine(Uri, "token"));
            RestRequest request = new(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("undefined", "grant_type=password&username=" + userName + "&password=" + password + "", ParameterType.RequestBody);

            IRestResponse<TokenResponse> response = await client.ExecuteAsync<TokenResponse>(request);
            AuthenticationToken = response.Data?.access_token;
        }

        public T CreateEndpointService<T>() where T : class, IEndpointService, new() => new();
    }
}