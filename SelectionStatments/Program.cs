#region if Statement

using SelectionStatments;

string password = "interstellar";

WriteLine(password.Length < 8 ? "Your password is too short. Use at least 8 chars." : "your password is strong.");

// This is the longer way of writing the same thing
//if (password.Length < 8)
//{
//    WriteLine("Your password is too short. Use at least 8 chars.");
//}
//else
//{
//    WriteLine("your password is strong.");
//}

#endregion

#region pattern matching with the if statement

// Add and remove the "" to change between string and int.

object o = 3;
int j = 4;

if (o is int i)
{
    WriteLine($"\n\n{i} x {j} = {i * j}");
}
else
{
    WriteLine("\n\no is not an int so it cannot multiply!");
}

#endregion

#region Branching with the switch statement

// Inclusive lower bound but exclusive upper bound.
int number = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"\n\nMy random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break; // Jumps to end of switch statement.
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // Multiple case section.
    case 4:
        WriteLine("Three or Four");
        goto case 1;
    case 5:
        goto A_label;
    default:
            WriteLine("Default");
            break;
} // End of switch statement
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");

#endregion

#region Pattern matching with statements

var animals = new Animals?[]
{
    new Cat { Name = "Karen", Born = new(2022, 8, 23), Legs = 4, IsDomestic = true }, null,
    new Cat { Name = "Mufasa", Born = new(1994, 6, 12) },
    new Spider { Name = "Sid  Vicious", Born = DateTime.Today, IsVenomous = true },
    new Spider { Name = "Captin Furry", Born = DateTime.Today }

};


foreach (Animals? animal in animals )
{
    string message;

    switch (animal)
    {
        
    }
}

#endregion