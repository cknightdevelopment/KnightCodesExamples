using System;

namespace Quartz.Listeners.Listeners
{
    class TriggerListener : ITriggerListener
    {
        private static void Write(string text, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text, args);
            Console.ResetColor();
        }

        public string Name
        {
            get { return "GlobalTriggerListener"; }
        }

        public void TriggerFired(ITrigger trigger, IJobExecutionContext context)
        {
            Write("{0} -- {1} -- Trigger ({2}) was fired", Name, DateTime.Now, trigger.Key);
        }

        /*
         * NOTE: the return of this method determines if the job execution should be vetoed or not, so be sure to
         * return true unless you really want to veto the job.
         */
        public bool VetoJobExecution(ITrigger trigger, IJobExecutionContext context)
        {
            Write("{0} -- {1} -- Trigger ({2}) is not going to veto the job ({3})", Name, DateTime.Now, trigger.Key, context.JobDetail.Key);
            return false;
        }

        public void TriggerMisfired(ITrigger trigger)
        {
            Write("{0} -- {1} -- Trigger ({2}) was misfired", Name, DateTime.Now, trigger.Key);
        }

        public void TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
            Write("{0} -- {1} -- Trigger ({2}) completed", Name, DateTime.Now, trigger.Key);
        }
    }
}