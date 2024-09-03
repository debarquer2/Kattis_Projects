using System;

// Based on: https://open.kattis.com/problems/fizzbuzz

//FizzBuzz(Console.ReadLine().Split(" ")); // For use with Kattis
FizzBuzz("3 5 15".Split()); // For testing purposes

static void FizzBuzz(string[] s)
{
    int X = int.Parse(s[0]);
    int Y = int.Parse(s[1]);
    int N = int.Parse(s[2]);

    for (int i = 1; i <= N; i++)
    {
        if (i % X == 0 && i % Y == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % X == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % Y == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}

