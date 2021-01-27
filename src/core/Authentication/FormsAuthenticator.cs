using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class FormsAuthenticator : IAuthenticator
    {
        private readonly string _uri;
        private readonly string _userName;
        private readonly string _password;

        public FormsAuthenticator(string uri, string userName, string password)
        {
            _uri = uri.EnsureTrailingSlash();
            _userName = userName;
            _password = password;
        }

        public async Task<string> AuthenticateAsync()
        {
            RestClient client = new(Path.Combine(_uri, "token"));
            RestRequest request = new(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("undefined", "grant_type=password&username=" + _userName + "&password=" + _password + "", ParameterType.RequestBody);

            IRestResponse<TokenResponse> response = await client.ExecuteAsync<TokenResponse>(request);

            return response.StatusCode != HttpStatusCode.OK
                ? throw new Exception(response.Content)
                : response.Data?.access_token;
        }
    }
}