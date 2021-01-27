using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{

    /// <summary>
    ///
    /// </summary>
    public class ImportEndpointService : EndpointService<ImportRequest>, IImportEndpointService
    {
        public ImportEndpointService(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public Task InsertData(ImportRequest requestParameters)
            => Execute("api/Import/InsertData", Method.POST, requestParameters);

        public Task<ImportSet> Insert(ImportRequest requestParameters)
            => Execute<ImportSet>("api/Import/Insert", Method.POST, requestParameters);
    }
}