using System;

namespace Quartz.Listeners
{
    class ExampleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--> Executing the example job");
            Console.ResetColor();
        }
    }
}