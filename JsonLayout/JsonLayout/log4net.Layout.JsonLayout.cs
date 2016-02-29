﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net.Layout
{
    public class JsonLayout : log4net.Layout.LayoutSkeleton
    {
        public override void ActivateOptions() {
            IgnoresException = false;
        }

        public override void Format(System.IO.TextWriter writer, Core.LoggingEvent loggingEvent) {
            writer.Write(Newtonsoft.Json.JsonConvert.SerializeObject(loggingEvent));
        }
    }
}