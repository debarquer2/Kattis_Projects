// Based on https://open.kattis.com/problems/heimavinna

//string input = System.Console.ReadLine(); // For use with kattis
string input = "1-3;5;7;10-13"; // For testing purposes

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
            nrOfproblems += int.Parse(a) - prevNumber + 1; // To account for all the assignments we need to add a +1 here
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
    nrOfproblems += int.Parse(a) - prevNumber + 1; // To account for all the assignments we need to add a +1 here
    a = "";
    prevNumber = -1;
}
else
{
    nrOfproblems++;
    a = "";
}

System.Console.WriteLine(nrOfproblems);