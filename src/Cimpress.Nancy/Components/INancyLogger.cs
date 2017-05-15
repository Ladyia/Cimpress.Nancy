﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cimpress.Nancy.Components
{
    public interface INancyLogger
    {
        void Debug(object data);
        void Info(object data);
        void Error(object data);
    }
}
