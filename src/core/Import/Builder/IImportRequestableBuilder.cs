namespace Dime.Scheduler.Sdk.Import.Builder
{
    public interface IImportRequestableBuilder<out T> where T : IImportRequestable
    {
        public T Create();
    }
}