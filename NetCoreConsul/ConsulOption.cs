﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreConsul
{
    public class ConsulOption
    {

        public string ServiceName { get; set; }
        public string ServiceIP { get; set; }
        public int ServicePort { get; set; }
        public string ServiceHealthCheck { get; set; }
        public string Address { get; set; }

    }
}
