using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public interface IValidatableImportRequest<out T> : IValidatableObject
    {
        T Validate(TransactionType transactionType);
    }
}