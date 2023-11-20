using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Models
{
    public interface IValidatableImportRequest<out T> : IValidatableObject
    {
        T Validate(TransactionType transactionType);
    }
}