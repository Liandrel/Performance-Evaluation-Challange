using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfEvalChallange
{
    public static class PerformanceClass
    {
        public static void CalculateSpeed(Action<int> methodToTest, int[] repetitions, string testName)
        {
            for (int i = 0; i < repetitions.Length; i++)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                stopwatch.Start();

                methodToTest(repetitions[i]);

                stopwatch.Stop();
                Console.WriteLine($"{testName} {repetitions[i]} reps: {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
