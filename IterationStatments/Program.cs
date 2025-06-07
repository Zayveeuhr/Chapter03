#region Looping with the while statement

using System.Reflection.Metadata;

int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}

#endregion

#region Looping with the do statement
// commited out so I do not have ot enter password every time I run the program.

//string? actualPassword = "pa$$w0rd";
//string? password;
//int? count = 0;

//do
//{
//    count++;
//    if (count == 4)
//    {
//        break;
//    }

//    Write("Enter your password: ");
//    password = ReadLine();

//} while (password != actualPassword);

//WriteLine(count == 4? "\nError to many attempts": "Correct!");

#endregion

#region Loop with the for loop statement

WriteLine();
for (int y =1; y <= 10; y ++)
{
    WriteLine(y);
}

for (int y = 0; y <= 10; y += 3)
{
    WriteLine(y);
}

#endregion

#region Looping with foreach

string[] names = { "Adam", "Barry", "Charlie" };
WriteLine("\n\n");
foreach (var name in names)
{
    WriteLine($"{name} has {name.Length} charaters.");
}

#endregion