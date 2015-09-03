using System;
using Quartz;

namespace QuartzWithListeners
{
    class SchedulerListener : ISchedulerListener
    {
        public void JobScheduled(ITrigger trigger)
        {
            Console.WriteLine("{0} -- {1} -- JobScheduled() was called", this.GetType().Name, DateTime.Now);
        }

        public void JobUnscheduled(TriggerKey triggerKey)
        {
            Console.WriteLine("{0} -- {1} -- JobUnscheduled() was called", this.GetType().Name, DateTime.Now);
        }

        public void TriggerFinalized(ITrigger trigger)
        {
            Console.WriteLine("{0} -- {1} -- TriggerFinalized() was called", this.GetType().Name, DateTime.Now);
        }

        public void TriggerPaused(TriggerKey triggerKey)
        {
            Console.WriteLine("{0} -- {1} -- TriggerPaused() was called", this.GetType().Name, DateTime.Now);
        }

        public void TriggersPaused(string triggerGroup)
        {
            Console.WriteLine("{0} -- {1} -- TriggersPaused() was called", this.GetType().Name, DateTime.Now);
        }

        public void TriggerResumed(TriggerKey triggerKey)
        {
            Console.WriteLine("{0} -- {1} -- TriggerResumed() was called", this.GetType().Name, DateTime.Now);
        }

        public void TriggersResumed(string triggerGroup)
        {
            Console.WriteLine("{0} -- {1} -- TriggersResumed() was called", this.GetType().Name, DateTime.Now);
        }

        public void JobAdded(IJobDetail jobDetail)
        {
            Console.WriteLine("{0} -- {1} -- JobAdded() was called", this.GetType().Name, DateTime.Now);
        }

        public void JobDeleted(JobKey jobKey)
        {
            Console.WriteLine("{0} -- {1} -- JobDeleted() was called", this.GetType().Name, DateTime.Now);
        }

        public void JobPaused(JobKey jobKey)
        {
            Console.WriteLine("{0} -- {1} -- JobPaused() was called", this.GetType().Name, DateTime.Now);
        }

        public void JobsPaused(string jobGroup)
        {
            Console.WriteLine("{0} -- {1} -- JobsPaused() was called", this.GetType().Name, DateTime.Now);
        }

        public void JobResumed(JobKey jobKey)
        {
            Console.WriteLine("{0} -- {1} -- JobResumed() was called", this.GetType().Name, DateTime.Now);
        }

        public void JobsResumed(string jobGroup)
        {
            Console.WriteLine("{0} -- {1} -- JobsResumed() was called", this.GetType().Name, DateTime.Now);
        }

        public void SchedulerError(string msg, SchedulerException cause)
        {
            Console.WriteLine("{0} -- {1} -- SchedulerError() was called", this.GetType().Name, DateTime.Now);
        }

        public void SchedulerInStandbyMode()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerInStandbyMode() was called", this.GetType().Name, DateTime.Now);
        }

        public void SchedulerStarted()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerStarted() was called", this.GetType().Name, DateTime.Now);
        }

        public void SchedulerStarting()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerStarting() was called", this.GetType().Name, DateTime.Now);
        }

        public void SchedulerShutdown()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerShutdown() was called", this.GetType().Name, DateTime.Now);
        }

        public void SchedulerShuttingdown()
        {
            Console.WriteLine("{0} -- {1} -- SchedulerShuttingdown() was called", this.GetType().Name, DateTime.Now);
        }

        public void SchedulingDataCleared()
        {
            Console.WriteLine("{0} -- {1} -- SchedulingDataCleared() was called", this.GetType().Name, DateTime.Now);
        }
    }
}