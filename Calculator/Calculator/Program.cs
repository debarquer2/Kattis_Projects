// https://open.kattis.com/problems/calculator

//string line;
//string s = "";
//while ((line = Console.ReadLine()) != null)
//{
//    s += line;
//}

using System.Reflection.Metadata.Ecma335;

string s = "5 - 3-2 + 5 * 2";
string operators = "+-*/()";


//string s2 = "2 + 3 * 3 * 5 + 5 * 4 / 2 + 2 + 4 - 13";
//string s2 = "(2 + 3) + (20 - 2 * (2 + 3))";
string s2 = Console.ReadLine();

//string s2 = "2+ 3 * 2";

Console.WriteLine(s2);
s2 = ResolveParanthesis(s2.ToCharArray());
Console.WriteLine(s2);

char[] inputArray = s.ToCharArray();
int number1 = -1;
int number2 = -1;

//string testa = Generic(operators, s2.ToCharArray(), '*', ((int, int) num) => num.Item1 * num.Item2);

//Console.WriteLine(testa);

//testa = Generic(operators, testa.ToCharArray(), '/', ((int, int) num) => num.Item1 / num.Item2);

//Console.WriteLine(testa);

//testa = Generic(operators, testa.ToCharArray(), '+', ((int, int) num) => num.Item1 + num.Item2);

//Console.WriteLine(testa);

//testa = Generic(operators, testa.ToCharArray(), '-', ((int, int) num) => num.Item1 - num.Item2);

//Console.WriteLine(testa);

string ResolveParanthesis(char[] inputArray)
{
    string userInput = "";
    string s = "";
    int nrOfLeftBrackets = 0;
    foreach (char c in inputArray)
    {
        if (c == ')')
        {
            nrOfLeftBrackets--;
            if(nrOfLeftBrackets == 0)
            {
                //Console.WriteLine("[1]" + new string(inputArray) + "->" + s);
                s += ResolveParanthesis((userInput).ToCharArray());
                Console.WriteLine("----");
                //Console.WriteLine("[2]" + s);
                userInput = "";
            }
        }
        else if (c == '(')
        {
            s += userInput;
            userInput = "";
            nrOfLeftBrackets++;
        }
        else
        {
            userInput += c;
        }
    }

    if (s == "") s = new string(inputArray);

    string tmp = "";
    tmp = Generic(operators, s.ToCharArray(), '*', ((int, int) num) => num.Item1 * num.Item2);
    tmp = Generic(operators, tmp.ToCharArray(), '/', ((int, int) num) => num.Item1 / num.Item2);
    tmp = Generic(operators, tmp.ToCharArray(), '+', ((int, int) num) => num.Item1 + num.Item2);
    tmp = Generic(operators, tmp.ToCharArray(), '-', ((int, int) num) => num.Item1 - num.Item2);

    s = tmp;

    return s;
}

string Generic(string operators, char[] inputArray, char currentOp, Func<(int, int), int> opFunc)
{
    int number1 = -1;
    string userInput = "";
    string s2 = "";
    bool correctOperator = false;
    char op = ' ';
    foreach (char c in inputArray)
    {
        if (c == ' ')
        {
            if (number1 == -1)
            {
                int testInt;
                if (!int.TryParse(userInput, out testInt)) continue;
                number1 = testInt;
                userInput = "";
            }
            else
            {
                int testInt;
                if (!int.TryParse(userInput, out testInt)) continue;
                if (correctOperator)
                {
                    // s2 += (number1 * testInt) + " ";
                    number1 = opFunc((number1, testInt));
                    userInput = "";
                    correctOperator = false;
                }
                else
                {
                    s2 += $"{number1} {op} ";
                    number1 = testInt;
                    userInput = "";
                }
            }
        }
        else if (c == currentOp)
        {
            correctOperator = true;
        }
        else if (operators.Contains(c))
        {
            correctOperator = false;
            op = c;
        }
        else
        {
            userInput += c;
        }
    }

    if (number1 == -1)
    {
        s2 += userInput;
    }
    else
    {
        int testInt;
        if (int.TryParse(userInput, out testInt))
        {
            if (correctOperator)
            {
                s2 += opFunc((number1, testInt)) + " ";
                number1 = -1;
                userInput = "";
            }
            else
            {
                s2 += $"{number1} {op} {userInput} ";
                number1 = -1;
                userInput = "";
            }
        }
        else
        {
            s2 += number1 + userInput;
        }
    }

    return s2;
}