namespace Dime.Scheduler.Sdk.Models
{
    public struct ImportParameter
    {
        public ImportParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }

        public object Value { get; }
    }
}