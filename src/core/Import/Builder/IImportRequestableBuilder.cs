namespace Dime.Scheduler.Sdk.Import
{
    public interface IImportRequestableBuilder<out T> where T : IImportRequestable
    {
        public T Create();
    }
}