namespace Dime.Scheduler.Sdk.Models.Builder
{
    public interface IImportRequestableBuilder<out T> where T : IImportRequestable
    {
        public T Create();
    }
}