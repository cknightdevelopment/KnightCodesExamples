using System;
using Quartz;

namespace QuartzWithNinject
{
    [DisallowConcurrentExecution]
    class DogJob : IJob
    {
        private readonly IDog _dog;

        public DogJob(IDog dog)
        {
            _dog = dog;
        }

        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("------------------------{0}------------------------", context.FireTimeUtc.Value.ToLocalTime());
            _dog.Bark();
            _dog.ChaseMailman(8);
        }
    }
}