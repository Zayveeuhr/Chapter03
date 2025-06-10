

#region handling overflow

using System.Transactions;

checked
{
    try
    {
        int max = 500;

        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    }
    catch (OverflowException e)
    {
        WriteLine($"{e.GetType()} says {e.Message}");
    }
}

#endregion

#region FizzBuzz Game

//string three = "Fizz";
//string five = "Buzz";

//for (int i = 1; i <= 100; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Write($"{three}{five}, ");
//    }
//    else if (i % 3 == 0)
//    {
//        Write($"{three}, ");
//    }
//    else if (i % 5 == 0)
//    {
//        Write($"{five}, ");
//    }
//    else Write($"{i}, ");
//}

// Example
for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        Write("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Write("Buzz");
    }
    else if (i % 3 == 0)
    {
        Write("Fizz");
    }
    else
    {
        Write(i);
    }

    // put a comma and space after every number except 100
    if (i < 100) Write(", ");

    // write a carriage-return after every ten numbers
    if (i % 10 == 0) WriteLine();
}
WriteLine();
#endregion

