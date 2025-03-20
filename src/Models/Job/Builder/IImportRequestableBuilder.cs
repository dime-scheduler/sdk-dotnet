namespace Dime.Scheduler.Entities.Builder
{
    public interface IImportRequestableBuilder<out T> where T : IImportRequestable
    {
        public T Create();
    }
}