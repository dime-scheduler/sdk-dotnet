using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface ILicenseEndpoint : IEndpoint
    {
        Task PostAsync(LicenseRequest request);
    }
}