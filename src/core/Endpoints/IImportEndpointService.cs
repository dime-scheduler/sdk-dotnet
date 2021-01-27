using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IImportEndpointService : IEndpointService
    {
        Task InsertData(ImportRequest requestParameters);
        Task<ImportSet> Insert(ImportRequest requestParameters);
    }
}