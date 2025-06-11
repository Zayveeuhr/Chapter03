

#region Prasactice exception handling

//Write("Enter a number between 0 and 255: ");
//string firstNumber = ReadLine();
//Write("Enter another number between 0 and 255: ");
//string secondNumber = ReadLine();
//try
//{
//    WriteLine($"{firstNumber} divided by {secondNumber} is {byte.Parse(firstNumber) / byte.Parse(secondNumber)}");
//}
//catch (FormatException e)
//{
//    WriteLine($"{e.GetType().Name}: {e.Message}");
//}

////Exampple 
//Write("Enter a number between 0 and 255: ");
//string n1 = ReadLine()!;

//Write("Enter another number between 0 and 255: ");
//string n2 = ReadLine()!;

//try
//{
//    byte a = byte.Parse(n1);
//    byte b = byte.Parse(n2);

//    int answer = a / b;

//    WriteLine($"{a} divided by {b} is {answer}");
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType().Name}: {ex.Message}");
//}

#endregion

checked
{
    int max = int.MaxValue;

    WriteLine($"{max + 1}");
}