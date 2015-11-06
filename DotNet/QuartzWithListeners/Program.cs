using System;
using System.Threading;
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
            scheduler.ListenerManager.AddJobListener(new JobListener(), GroupMatcher<JobKey>.AnyGroup());

            // add global trigger listener
            scheduler.ListenerManager.AddTriggerListener(new TriggerListener(), GroupMatcher<TriggerKey>.AnyGroup());

            // add jobs & triggers
            scheduler.ScheduleJob(
                JobBuilder.Create<ExampleJob>().WithIdentity("MyJob", "MyJobGroup").Build(),
                TriggerBuilder.Create().WithIdentity("MyTrigger", "MyTriggerGroup")
                    .WithSimpleSchedule(s => s.WithIntervalInSeconds(2).RepeatForever()).Build());


            scheduler.Start(); // start scheduler
            Thread.Sleep(5000); // sleep the main thread (Quartz will fire the job 3x on other threads)
            scheduler.Shutdown(true); // stop the scheduler

            Console.ReadLine();
        }
    }
}
