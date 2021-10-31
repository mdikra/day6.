using System;
using System.Collections.Generic;
using System.Text;

namespace Logicalprogram
{
    class Stopwatch
    {
        public int Elapsed { get; private set; }

        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // ... This takes 10 seconds to finish.
            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
            }

            // Stop.
            stopwatch.Stop();

            // Write hours, minutes and seconds.
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void Stop()
        {
            throw new NotImplementedException();
        }

        private void Start()
        {
            throw new NotImplementedException();
        }
    }
}
