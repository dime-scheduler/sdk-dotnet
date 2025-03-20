using System.Collections.Generic;
using System.Linq;

namespace Dime.Scheduler.Requests
{
    public class Sorters<T> : List<Sorter<T>>
    {
        public override string ToString()
        {
            string sortersString = string.Join(",", this.Select(x => x.ToString()));
            return $"[{sortersString}]";
        }
    }
}