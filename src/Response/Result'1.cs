namespace Dime.Scheduler
{
    public class Result<T> : Result
    {
        internal Result(T? value, bool isSuccess, string? error = null) : base(isSuccess, error)
        {
            Value = value;
        }

        internal T? Value { get; }
    }
}