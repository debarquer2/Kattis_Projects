// Based on https://open.kattis.com/problems/fizzbuzz2

using System;

//string[] nm = Console.ReadLine().Split(" ");
string[] nm = "3 15".Split(" ");

int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

int bestNrOfAnswers = -1;
int bestCandidateId = -1;

string[] lines = { "1 2 fizz 4 5 fizz 7 8 fizz 10 11 fizz 13 14 fizz", "1 2 3 4 buzz 6 7 8 9 buzz 11 12 13 14 buzz", "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz" };

for (int i = 0; i < n; i++)
{
    int nrOfCorrectAnswers = 0;

    //string[] split = Console.ReadLine().Split(" "); // For use with Kattis
    string[] split = lines[i].Split(" "); // For testing purposes

    for (int j = 0; j < m; j++) //m == split.Length
    {
        string s = split[j];
        if (CheckAnswer(j + 1, 3, 5, s)) nrOfCorrectAnswers++;
    }

    if(nrOfCorrectAnswers > bestNrOfAnswers)
    {
        bestNrOfAnswers = nrOfCorrectAnswers;
        bestCandidateId = i + 1;
    }
}

Console.WriteLine(bestCandidateId);

bool CheckAnswer(int n, int x, int y, string value)
{
    return GetAnswer(n, x, y) == value;
}

string GetAnswer(int n, int x, int y)
{
    if (n % x == 0 && n % y == 0)
    {
        return "fizzbuzz";
    }
    else if (n % x == 0)
    {
        return "fizz";
    }
    else if (n % y == 0)
    {
        return "buzz";
    }
    else
    {
        return n.ToString();
    }
}