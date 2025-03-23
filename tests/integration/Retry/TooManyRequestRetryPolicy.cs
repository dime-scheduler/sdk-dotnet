using System;
using System.Net;
using System.Threading.Tasks;
using Polly;
using Polly.Retry;

namespace Dime.Scheduler.IntegrationTests.Retry
{
    internal class TooManyRequestRetryPolicy
    {
        public static async Task<Result> ExecuteAsync(Func<Task<Result>> action)
        {
            AsyncRetryPolicy<Result> retryPolicy = Policy
                .HandleResult<Result>(r => r != null && r.Error != null && (r.Error?.StatusCode ?? 0) == (int)HttpStatusCode.TooManyRequests)
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(3, retryAttempt)));

            return await retryPolicy.ExecuteAsync(action);
        }
    }
}