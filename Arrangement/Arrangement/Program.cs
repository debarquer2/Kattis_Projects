using System.Diagnostics;

Test1(100000000, 330000000);
Test2(100000000, 330000000);

static void Test1(int n, int m)
{
    var watch = System.Diagnostics.Stopwatch.StartNew();

    int first = m / n; //6
    int remainder = m - (first * n); // 30, alternatively m % n 

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < first; j++)
        {
            //System.Console.Write('*');
        }
        if (remainder > 0)
        {
            //System.Console.Write('*');
            remainder--;
        }
        //System.Console.Write('\n');
    }

    watch.Stop();
    var elapsedMs = watch.ElapsedMilliseconds;
    Console.WriteLine($"Time: {elapsedMs} {Stopwatch.IsHighResolution}");
}

static void Test2(int n, int m)
{
    var watch = System.Diagnostics.Stopwatch.StartNew();

    int first = m / n; //6
    int remainder = m - (first * n); // 30, alternatively m % n 

    string small = "";
    for(int i = 0; i < first; i++)
    {
        small += "*";
    }
    string large = small + "*";

    for (int i = 0; i < n; i++)
    {
        if (remainder > 0)
        {
            //System.Console.Write(large);
            remainder--;
        }
        else
        {
            //System.Console.Write(small);
        }
        //System.Console.Write('\n');
    }

    watch.Stop();
    var elapsedMs = watch.ElapsedMilliseconds;
    Console.WriteLine($"Time: {elapsedMs} {Stopwatch.IsHighResolution}");
}