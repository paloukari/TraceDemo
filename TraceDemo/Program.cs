using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = LoggerFactory.GetLogger();

            logger.Info("info");
            logger.Warn("warning");
            logger.Error("error");
        }
    }
}
