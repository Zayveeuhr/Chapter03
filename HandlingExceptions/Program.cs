
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

using System.Runtime.CompilerServices;

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

#region Disabling compiler ovberflow checks with the unchecked statements



unchecked
{
    WriteLine();
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}

#endregion

#region Result type in .NET

public class Result<T>
{
    public T Value { get; }
    public bool IsSuccess { get; }
    public string ErrorMessage { get; }

    private Result(T value, bool isSuccess, string errorMessage)
    {
        Value = value;
        IsSuccess = isSuccess;
        ErrorMessage = errorMessage;
    }

    public static Result<T> Success(T value) => new Result<T>(value, true, null);
    public static Result<T> Failure(string errorMessage) => new Result<T>(default, false, errorMessage);
}

#endregion

