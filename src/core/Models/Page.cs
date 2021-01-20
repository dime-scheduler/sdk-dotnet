using System.Collections.Generic;

namespace Dime.Scheduler.Sdk
{
    public class Page<T>
    {
        public IEnumerable<T> Data { get; set; }
    }
}