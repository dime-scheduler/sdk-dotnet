﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dime.Scheduler
{
    public interface IReadEndpoint<in T, Y> : IEndpoint where T : class
    {
        Task<IEnumerable<Y>> GetAsync(T request);
    }
}