
#region Using the try catch block

//WriteLine("Before parsing");
//Write("What is your age? ");
//string? input = ReadLine();

////if (input is null)
////{
////    WriteLine("You did not enter a value so the app has ended.");
////    return; // Exit the app.
////}

//try
//{
//    int age = int.Parse(input!);
//    WriteLine($"You are {age} years old.");
//}
//catch (OverflowException)
//{
//    WriteLine("Your age is a valid number format but is ether too big or small.");
//}
//catch (FormatException)
//{
//    WriteLine("The age you entered is not a valid number format.");
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType()} Says {ex.Message}");
//}
//WriteLine("After parsing");
#endregion

#region Catching with filters

//Write("Enter an amount: ");
//string? amount = ReadLine();

//if (string.IsNullOrEmpty(amount)) return;

//try
//{
//    decimal amountValue = decimal.Parse(amount);
//    WriteLine($"Amount formatted as currency: {amountValue:C}");
//}
//catch (FormatException) when (amount.Contains('$'))
//{
//    WriteLine("Amounts cannot use the dollar sign!");
//}
//catch (FormatException)
//{
//    WriteLine("Amounts must only contain digits");
//}
#endregion

#region Throwing overflow exceptions with the checked statement
//checked
//{
//    int x = int.MaxValue - 1;

//    WriteLine($"Initial value: {x}");
//    x++;
//    WriteLine($"After incrementing: {x}");
//    x++;
//    WriteLine($"After incrementing: {x}");
//    x++;
//    WriteLine($"After incrementing: {x}");
//}

try
{
    checked
    {
        int x = int.MaxValue - 1;

        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caught the exception");
}
//int x = int.MaxValue - 1;

//WriteLine($"Initial value: {x}");
//x++;
//WriteLine($"After incrementing: {x}");
//x++;
//WriteLine($"After incrementing: {x}");
//x++;
//WriteLine($"After incrementing: {x}");
#endregion

