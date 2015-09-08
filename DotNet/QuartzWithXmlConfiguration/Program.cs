using Quartz.Impl;

namespace QuartzWithXmlConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            var scheduler = new StdSchedulerFactory().GetScheduler();
            scheduler.Start();
        }
    }
}
