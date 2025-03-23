namespace Dime.Scheduler
{
    public class Error
    {
        internal Error(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public int StatusCode { get; private set; }
        public string Message { get; private set; }

        public override string ToString() => $"Status code: {StatusCode}, Message: {Message}";
    }
}