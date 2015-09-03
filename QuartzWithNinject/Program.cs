using Ninject;
using Quartz;
using Quartz.Impl;

namespace QuartzWithNinject
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = InitializeNinjectKernel();
            var scheduler = kernel.Get<IScheduler>();

            // add jobs and start scheduler
            scheduler.ScheduleJob(
                JobBuilder.Create<DogJob>().Build(), 
                TriggerBuilder.Create().WithSimpleSchedule(s => s.WithIntervalInSeconds(2).RepeatForever()).Build());

            // start scheduler
            scheduler.Start();
        }

        static IKernel InitializeNinjectKernel()
        {
            var kernel = new StandardKernel();

            // setup Quartz scheduler that uses our NinjectJobFactory
            kernel.Bind<IScheduler>().ToMethod(x =>
            {
                var sched = new StdSchedulerFactory().GetScheduler();
                sched.JobFactory = new NinjectJobFactory(kernel);
                return sched;
            });

            // add your Ninject bindings as you normally would (these are the bindings that your jobs require)
            kernel.Bind<IDog>().To<GoldenRetriever>();
            // etc.

            return kernel;
        }
    }
}
