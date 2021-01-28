using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IImportEndpoint : IEndpoint
    {
        Task RunAsync(IImportRequestable requestParameters);

        Task<ImportSet> ProcessAsync(IImportRequestable requestParameters);
    }
}