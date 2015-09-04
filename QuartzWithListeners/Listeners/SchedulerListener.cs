using System;
using Quartz;

namespace QuartzWithListeners.Listeners
{
    class SchedulerListener : ISchedulerListener
    {
        public void JobScheduled(ITrigger trigger)
        {
            Console.WriteLine("{0} -- {1} -- JobScheduled() was called", Name, DateTime.Now);
        }

        public void JobUnscheduled(TriggerKey triggerKey)
        {
            Console.WriteLine("{0} -- {1} -- JobUnscheduled() was called", Name, DateTime.Now);
        }

        public void TriggerFinalized(ITrigger trigger)
        {
            Console.WriteLine("{0} -- {1} -- TriggerFinalized() was called", Name, DateTime.Now);
        }

        public void TriggerPaused(TriggerKey triggerKey)
        {
            Console.WriteLine("{0} -- {1} -- TriggerPaused() was called", Name, DateTime.Now);
        }

        public void TriggersPaused(string triggerGroup)
        {
            Console.WriteLine("{0} -- {1} -- TriggersPaused() was called", Name, DateTime.Now);
        }

        public void TriggerResumed(TriggerKey triggerKey)
        {
            Console.WriteLine("{0} -- {1} -- TriggerResumed() was called", Name, DateTime.Now);
        }

        public void TriggersResumed(string triggerGroup)
        {
            Console.WriteLine("{0} -- {1} -- TriggersResumed() was called", Name, DateTime.Now);
        }

        public void JobAdded(IJobDetail jobDetail)
        {
            Console.WriteLine("{0} -- {1} -- JobAdded() was called", Name, DateTime.Now);
        }

        public void JobDeleted(JobKey jobKey)
        {
            Console.WriteLine("{0} -- {1} -- JobDeleted() was called", Name, DateTime.Now);
        }

        public void JobPaused(JobKey jobKey)
        {
            Console.WriteLine("{0} -- {1} -- JobPaused() was called", Name, DateTime.Now);
        }

        public void JobsPaused(string jobGroup)
        {
            Console.WriteLine("{0} -- {1} -- JobsPaused() was called", Name, DateTime.Now);
        }

        public void JobResumed(JobKey jobKey)
        {
            Console.WriteLine("{0} -- {1} -- JobResumed() was called", Name, DateTime.Now);
        }

        public void JobsResumed(string jobGroup)
        {
            Console.WriteLine("{0} -- {1} -- JobsResumed() was called", Name, DateTime.Now);
        }

        public void SchedulerError(string msg, SchedulerException cause)
        {
            Console.WriteLine("{0} -- {1} -- SchedulerError() was called", Name, DateTime.Now);
        }

        public void SchedulerInStandbyMode()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerInStandbyMode() was called", Name, DateTime.Now);
        }

        public void SchedulerStarted()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerStarted() was called", Name, DateTime.Now);
        }

        public void SchedulerStarting()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerStarting() was called", Name, DateTime.Now);
        }

        public void SchedulerShutdown()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerShutdown() was called", Name, DateTime.Now);
        }

        public void SchedulerShuttingdown()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerShuttingdown() was called", Name, DateTime.Now);
        }

        public void SchedulingDataCleared()
        {
            Console.WriteLine("{0} -- {1} -- SchedulingDataCleared() was called", Name, DateTime.Now);
        }

        public string Name { get { return "SchedulerListener"; } }
    }
}