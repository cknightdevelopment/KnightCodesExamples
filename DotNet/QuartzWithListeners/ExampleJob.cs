using System;
using Quartz;

namespace QuartzWithListeners
{
    class ExampleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("--> Executing the example job");
        }
    }
}