using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class ImportEndpointService : EndpointService<ImportRequest>, IImportEndpointService
    {
        public ImportEndpointService(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public Task InsertData(ImportRequest requestParameters)
            => Execute(Routes.Import.InsertData, Method.POST, requestParameters);

        public Task<ImportSet> Insert(ImportRequest requestParameters)
            => Execute<ImportSet>(Routes.Import.Insert, Method.POST, requestParameters);
    }
}