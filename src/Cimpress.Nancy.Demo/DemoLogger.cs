﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cimpress.Nancy.Components;

namespace Cimpress.Nancy.Demo
{
    public class DemoLogger : INancyLogger
    {
        public void Configure(IDictionary<string, string> options)
        {

        }

        public void Debug(object data)
        {
            Console.WriteLine($"Debug: {data}");
        }

        public void Info(object data)
        {
            Console.WriteLine($"Info: {data}");
        }

        public void Error(object data)
        {
            Console.WriteLine($"Error: {data}");
        }
    }
}
