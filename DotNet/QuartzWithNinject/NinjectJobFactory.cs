using System;
using Ninject;
using Quartz;
using Quartz.Simpl;
using Quartz.Spi;

namespace QuartzWithNinject
{
    class NinjectJobFactory : SimpleJobFactory
    {
        readonly IKernel _kernel;

        public NinjectJobFactory(IKernel kernel)
        {
            this._kernel = kernel;
        }

        public override IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            try
            {
                return (IJob) this._kernel.Get(bundle.JobDetail.JobType); // will inject dependencies that the job requires
            }
            catch (Exception e)
            {
                throw new SchedulerException(string.Format("Problem while instantiating job '{0}' from the NinjectJobFactory.", bundle.JobDetail.Key), e);
            }
        }
    }
}