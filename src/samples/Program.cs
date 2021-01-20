﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ResourcesRequestSample resourcesRequestSample = new();
            await resourcesRequestSample.Execute();

            ImportRequestSample sample = new();
            await sample.Execute();

            Console.ReadLine();
        }
    }
}
