using CommandLine;

namespace Dime.Scheduler.Sdk.Samples
{
    public class SampleOptions
    {
        [Option('r', "resource", Required = false, HelpText = "Execute resources import.")]
        public bool Resource { get; set; }

        [Option('t', "task", Required = false, HelpText = "Execute task import.")]
        public bool Task { get; set; }

        [Option('e', "exchangeappointment", Required = false, HelpText = "Execute Exchange appointment import.")]
        public bool ExchangeAppointment { get; set; }

        [Option('m', "message", Required = false, HelpText = "Execute Exchange appointment import.")]
        public bool Message { get; set; }

        [Option('f', "filter", Required = false, HelpText = "Execute filter import.")]
        public bool Filter { get; set; }

        [Option('g', "gpstracking", Required = false, HelpText = "Execute GPS tracking import.")]
        public bool ResourceGpsTracking { get; set; }

        [Option('n', "notification", Required = false, HelpText = "Execute notification import.")]
        public bool Notification { get; set; }
    }
}