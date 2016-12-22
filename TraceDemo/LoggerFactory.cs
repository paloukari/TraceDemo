using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracingDemo
{
    public class LoggerFactory
    {
        public static ILogger GetLogger(string source = "iBankSource")
        {
            return new Logger(source);
        }
    }
}
