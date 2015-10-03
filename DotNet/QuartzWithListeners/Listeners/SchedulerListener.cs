using System;
using Quartz;

namespace QuartzWithListeners.Listeners
{
    class SchedulerListener : ISchedulerListener
    {
        private static void Write(string text, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text, args);
            Console.ResetColor();
        }

        public string Name { get { return "SchedulerListener"; } }

        public void JobScheduled(ITrigger trigger)
        {
            Write("{0} -- {1} -- JobScheduled() was called", Name, DateTime.Now);
        }

        public void JobUnscheduled(TriggerKey triggerKey)
        {
            Write("{0} -- {1} -- JobUnscheduled() was called", Name, DateTime.Now);
        }

        public void TriggerFinalized(ITrigger trigger)
        {
            Write("{0} -- {1} -- TriggerFinalized() was called", Name, DateTime.Now);
        }

        public void TriggerPaused(TriggerKey triggerKey)
        {
            Write("{0} -- {1} -- TriggerPaused() was called", Name, DateTime.Now);
        }

        public void TriggersPaused(string triggerGroup)
        {
            Write("{0} -- {1} -- TriggersPaused() was called", Name, DateTime.Now);
        }

        public void TriggerResumed(TriggerKey triggerKey)
        {
            Write("{0} -- {1} -- TriggerResumed() was called", Name, DateTime.Now);
        }

        public void TriggersResumed(string triggerGroup)
        {
            Write("{0} -- {1} -- TriggersResumed() was called", Name, DateTime.Now);
        }

        public void JobAdded(IJobDetail jobDetail)
        {
            Write("{0} -- {1} -- JobAdded() was called", Name, DateTime.Now);
        }

        public void JobDeleted(JobKey jobKey)
        {
            Write("{0} -- {1} -- JobDeleted() was called", Name, DateTime.Now);
        }

        public void JobPaused(JobKey jobKey)
        {
            Write("{0} -- {1} -- JobPaused() was called", Name, DateTime.Now);
        }

        public void JobsPaused(string jobGroup)
        {
            Write("{0} -- {1} -- JobsPaused() was called", Name, DateTime.Now);
        }

        public void JobResumed(JobKey jobKey)
        {
            Write("{0} -- {1} -- JobResumed() was called", Name, DateTime.Now);
        }

        public void JobsResumed(string jobGroup)
        {
            Write("{0} -- {1} -- JobsResumed() was called", Name, DateTime.Now);
        }

        public void SchedulerError(string msg, SchedulerException cause)
        {
            Write("{0} -- {1} -- SchedulerError() was called", Name, DateTime.Now);
        }

        public void SchedulerInStandbyMode()
        {
            Write("{0} -- {1} -- SchedulerInStandbyMode() was called", Name, DateTime.Now);
        }

        public void SchedulerStarted()
        {
            Write("{0} -- {1} -- SchedulerStarted() was called", Name, DateTime.Now);
        }

        public void SchedulerStarting()
        {
            Write("{0} -- {1} -- SchedulerStarting() was called", Name, DateTime.Now);
        }

        public void SchedulerShutdown()
        {
            Write("{0} -- {1} -- SchedulerShutdown() was called", Name, DateTime.Now);
        }

        public void SchedulerShuttingdown()
        {
            Write("{0} -- {1} -- SchedulerShuttingdown() was called", Name, DateTime.Now);
        }

        public void SchedulingDataCleared()
        {
            Write("{0} -- {1} -- SchedulingDataCleared() was called", Name, DateTime.Now);
        }
    }
}