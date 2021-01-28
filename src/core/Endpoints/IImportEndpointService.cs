using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IImportEndpointService : IEndpointService
    {
        Task RunAsync(IImportRequestable requestParameters);

        Task<ImportSet> ProcessAsync(IImportRequestable requestParameters);
    }
}