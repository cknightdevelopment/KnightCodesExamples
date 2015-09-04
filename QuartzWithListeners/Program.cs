using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using QuartzWithListeners.Listeners;

namespace QuartzWithListeners
{
    class Program
    {
        static void Main(string[] args)
        {
            var scheduler = new StdSchedulerFactory().GetScheduler();

            // add scheduler listener
            scheduler.ListenerManager.AddSchedulerListener(new SchedulerListener());

            // add global job listener
            scheduler.ListenerManager.AddJobListener(new GlobalJobListener(), GroupMatcher<JobKey>.AnyGroup());

            // add global trigger listener
            scheduler.ListenerManager.AddTriggerListener(new GlobalTriggerListener(), GroupMatcher<TriggerKey>.AnyGroup());


            // add jobs & triggers and start scheduler as usual
            scheduler.ScheduleJob(
                JobBuilder.Create<ExampleJob>().WithIdentity("MyJob", "MyJobGroup").Build(),
                TriggerBuilder.Create().WithIdentity("MyTrigger", "MyTriggerGroup").WithSimpleSchedule(s => s.WithIntervalInSeconds(20).RepeatForever()).Build());

            scheduler.Start();
        }
    }
}
