// https://open.kattis.com/problems/heimavinna

//string input = System.Console.ReadLine();
string input = "1-3;5;7;10-13";

string a = "";

int nrOfproblems = 0;
int prevNumber = -1;

char[] inputArray = input.ToCharArray();
foreach(char c in inputArray)
{
    if(c == '-')
    {
        prevNumber = int.Parse(a);
        a = "";
    }
    else if (c == ';')
    {
        if(prevNumber > -1)
        {
            nrOfproblems += int.Parse(a) - prevNumber + 1; // Since the assignments are inclusive, for example 1-3 we need to add + 1 here
            a = "";
            prevNumber = -1;
        }
        else
        {
            nrOfproblems++;
            a = "";
        }
    }
    else{
        a += c;
    }
}

if (prevNumber > -1)
{
    nrOfproblems += int.Parse(a) - prevNumber + 1;
    a = "";
    prevNumber = -1;
}
else
{
    nrOfproblems++;
    a = "";
}

System.Console.WriteLine(nrOfproblems);