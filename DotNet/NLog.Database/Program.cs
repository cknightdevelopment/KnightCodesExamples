using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                int result = 5 / zero;
            }
            catch (DivideByZeroException ex)
            {
                // get a Logger object and log exception here using NLog. 
                // this will use the "databaseLogger" logger from our NLog.config file
                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Whoops!");
            }
        }
    }
}
