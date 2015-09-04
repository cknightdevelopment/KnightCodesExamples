using System;

namespace QuartzWithNinject
{
    class GoldenRetriever : IDog
    {
        public void Bark()
        {
            Console.WriteLine("Bark!");
        }

        public void ChaseMailman(int speed)
        {
            Console.WriteLine(speed >= 5 ? "Caught the mailman!" : "Couldn't catch the mailman, maybe next time.");
        }
    }
}