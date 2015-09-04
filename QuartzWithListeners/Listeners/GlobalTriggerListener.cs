using System;
using Quartz;

namespace QuartzWithListeners.Listeners
{
    class GlobalTriggerListener : ITriggerListener
    {
        public void TriggerFired(ITrigger trigger, IJobExecutionContext context)
        {
            Console.WriteLine("{0} -- {1} -- Trigger ({2}) was fired", Name, DateTime.Now, trigger.Key);
        }

        /*
         * NOTE: the return of this method determines if the job execution should be vetoed or not, so be sure to
         * return true unless you really want to veto the job. Here we have dummy code just to make it random.
         */
        public bool VetoJobExecution(ITrigger trigger, IJobExecutionContext context)
        {
            var doVeto = new Random().Next(1, 10) > 5;
            if (doVeto)
            {
                Console.WriteLine("{0} -- {1} -- Trigger ({2}) is going to veto the job ({3})", Name, DateTime.Now, trigger.Key, context.JobDetail.Key);
            }
            return doVeto;
        }

        public void TriggerMisfired(ITrigger trigger)
        {
            Console.WriteLine("{0} -- {1} -- Trigger ({2}) was misfired", Name, DateTime.Now, trigger.Key);
        }

        public void TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
            Console.WriteLine("{0} -- {1} -- Trigger ({2}) completed", Name, DateTime.Now, trigger.Key);
        }

        public string Name
        {
            get { return "GlobalTriggerListener"; }
        }
    }
}