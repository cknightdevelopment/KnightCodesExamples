using System;
using System.Threading;

namespace Quartz.XmlConfiguration
{
    class ExampleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("--> {0} - {1} - Executing the example job", DateTime.Now, Thread.CurrentThread.Name);
        }
    }
}