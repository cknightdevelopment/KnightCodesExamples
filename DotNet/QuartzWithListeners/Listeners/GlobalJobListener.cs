using System;
using Quartz;

namespace QuartzWithListeners.Listeners
{
    class GlobalJobListener : IJobListener
    {
        public void JobToBeExecuted(IJobExecutionContext context)
        {
            Console.WriteLine("{0} -- {1} -- Job ({2}) is about to be executed", Name, DateTime.Now, context.JobDetail.Key);
        }


        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            Console.WriteLine("{0} -- {1} -- Job ({2}) was executed", Name, DateTime.Now, context.JobDetail.Key);
        }


        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            Console.WriteLine("{0} -- {1} -- Job ({2}) was vetoed", Name, DateTime.Now, context.JobDetail.Key);
        }


        public string Name { get { return "GlobalJobListener"; } }
    }
}