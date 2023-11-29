using System;
using System.Net;

namespace Dime.Scheduler.Entities
{
    public class WebApiException : Exception
    {
        public WebApiException()
        {
        }

        public HttpStatusCode StatusCode { get; set; }

        public string Error { get; set; }

        public string Description { get; set; }
    }
}