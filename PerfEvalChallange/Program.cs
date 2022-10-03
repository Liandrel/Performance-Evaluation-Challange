using PerfEvalChallange;
using System.Diagnostics;
using System.Text;

////string test
//Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();

//string test = "";
//for (int i = 0; i < 50000; i++)
//{
//    test += "Testing";
//}

//stopwatch.Stop();
//Console.WriteLine($"Time Taken {stopwatch.ElapsedMilliseconds} ms");



////stringbuilder test
//stopwatch = Stopwatch.StartNew();
//stopwatch.Start();

//StringBuilder sb = new();
//for (int i = 0; i < 500000; i++)
//{
//    sb.Append("Testing");
//}

//string sbOut = sb.ToString();

//stopwatch.Stop();
//Console.WriteLine($"Time Taken {stopwatch.ElapsedMilliseconds} ms");


//int[] iterations = new int[] { 500, 5000, 50000 };

//PerformanceClass.CalculateSpeed(AppendTextTest, iterations, "Append Text");
//PerformanceClass.CalculateSpeed(AppendSbTest, iterations, "Append Sb");

int[] iterations = new int[] {500000,5000000,50000000 };
PerformanceClass.CalculateSpeed(DoubleTest, iterations, "Double Test");
PerformanceClass.CalculateSpeed(DecimalTest, iterations, "Decimal Test");


static void AppendTextTest(int repetitions)
{
    string test = "";
    for (int i = 0; i < repetitions; i++)
    {
        test += "Testing";
    }

}
static void AppendSbTest(int repetitions)
{
    StringBuilder sb = new();
    for (int i = 0; i < repetitions; i++)
    {
        sb.Append("Testing");
    }

    string sbOut = sb.ToString();
}
static void DoubleTest(int repetitions)
{
    double x = 4.25;
    double y = 25.75;
    for (int i = 0; i < repetitions; i++)
    {
        x += y;
    }
}
static void DecimalTest(int repetitions)
{
    decimal x = 4.25M;
    decimal y = 25.75M;
    for (int i = 0; i < repetitions; i++)
    {
        x += y;
    }
}
