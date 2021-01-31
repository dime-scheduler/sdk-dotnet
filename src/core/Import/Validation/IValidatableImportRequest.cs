using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public interface IValidatableImportRequest<out T> : IValidatableObject
    {
        T Validate(TransactionType transactionType);
    }
}