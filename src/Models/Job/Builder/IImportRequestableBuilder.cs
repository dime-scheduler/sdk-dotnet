namespace Dime.Scheduler.Entities.Builder
{
    public interface IImportRequestableBuilder<out T> where T : IImportEntity
    {
        public T Create();
    }
}