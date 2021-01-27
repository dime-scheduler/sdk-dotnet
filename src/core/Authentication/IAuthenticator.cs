using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IAuthenticator
    {
        Task<string> AuthenticateAsync();
    }
}