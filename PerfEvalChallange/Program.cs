using System.Diagnostics;
using System.Text;

//string test
Stopwatch stopwatch = Stopwatch.StartNew();
stopwatch.Start();

string test = "";
for (int i = 0; i < 50000; i++)
{
    test += "Testing";
}

stopwatch.Stop();
Console.WriteLine($"Time Taken {stopwatch.ElapsedMilliseconds} ms");



//stringbuilder test
stopwatch = Stopwatch.StartNew();
stopwatch.Start();

StringBuilder sb = new();
for (int i = 0; i < 500000; i++)
{
    sb.Append("Testing");
}

string sbOut = sb.ToString();

stopwatch.Stop();
Console.WriteLine($"Time Taken {stopwatch.ElapsedMilliseconds} ms");