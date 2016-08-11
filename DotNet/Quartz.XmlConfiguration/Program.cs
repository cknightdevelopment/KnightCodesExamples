using Quartz.Impl;

namespace Quartz.XmlConfiguration
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
