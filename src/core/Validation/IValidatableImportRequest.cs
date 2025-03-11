using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    internal interface IValidatableImportRequest<out T> : IValidatableObject
    {
        T Validate(TransactionType transactionType);
    }
}