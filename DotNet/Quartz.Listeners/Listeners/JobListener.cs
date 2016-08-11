using System;

namespace Quartz.Listeners.Listeners
{
    class JobListener : IJobListener
    {
        private static void Write(string text, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text, args);
            Console.ResetColor();
        }

        public string Name { get { return "GlobalJobListener"; } }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            Write("{0} -- {1} -- Job ({2}) is about to be executed", Name, DateTime.Now, context.JobDetail.Key);
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            Write("{0} -- {1} -- Job ({2}) was executed", Name, DateTime.Now, context.JobDetail.Key);
        }

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            Write("{0} -- {1} -- Job ({2}) was vetoed", Name, DateTime.Now, context.JobDetail.Key);
        }
    }
}