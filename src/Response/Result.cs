namespace Dime.Scheduler
{
    public class Result
    {
        protected Result(bool isSuccess, Error? error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }

        protected Result(bool isSuccess) : this(isSuccess, null)
        {
        }

        public bool IsFailure => !IsSuccess;

        public bool IsSuccess { get; }

        public Error Error { get; }

        internal static Result Fail(Error error)
            => new(false, error);

        internal static Result<T> Fail<T>(Error error)
            => new(default, false, error);

        internal static Result Ok()
            => new(true);

        internal static Result<T> Ok<T>(T value)
            => new(value, true);
    }
}