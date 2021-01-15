using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public class ImportEndpointService : EndpointService<ImportRequest>, IEndpointService<ImportRequest>
    {
        public Task Create(ImportRequest requestParameters)
            => Execute("api/Import/InsertData", Method.POST, requestParameters);

        public Task Update(ImportRequest requestParameters)
            => Execute("api/Import/InsertData", Method.POST, requestParameters);

        public Task Delete(ImportRequest requestParameters)
            => Execute("api/Import/InsertData", Method.POST, requestParameters);
    }
}