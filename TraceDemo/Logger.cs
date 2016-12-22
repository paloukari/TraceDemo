using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracingDemo
{
    internal class Logger : ILogger
    {
        TraceSource _ts;
        public Logger(string source)
        {
            _ts = new TraceSource(source);
        }

        public void Error(string message)
        {
            _ts.TraceEvent(TraceEventType.Error, 0, message);
        }

        public void Info(string message)
        {
            _ts.TraceEvent(TraceEventType.Information, 0, message); 
        }

        public void Warn(string message)
        {
            _ts.TraceEvent(TraceEventType.Warning, 0, message);
            //Trace.TraceWarning(message);
        }
    }
}
