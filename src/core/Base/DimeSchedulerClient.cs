using System.IO;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerClient
    {
        public string Uri { get; }
        public bool Authenticated => !string.IsNullOrEmpty(AuthenticationToken);
        private string AuthenticationToken { get; set; }

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
            RestClient client = new RestClient(Path.Combine(Uri, "token"));
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("undefined", "grant_type=password&username=" + userName + "&password=" + password + "", ParameterType.RequestBody);

            IRestResponse<TokenResponse> response = await client.ExecuteAsync<TokenResponse>(request);
            AuthenticationToken = response.Data?.access_token;
        }

        public T CreateEndpointService<T>() where T : class, IEndpointService, new() => new T();
    }
}