#region Looping with the while statement

int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}

#endregion

#region Looping with the do statement

string? actualPassword = "pa$$w0rd";
string? password;
int? count = 0;

do
{
    count++;
    if (count == 4)
    {
        break;
    }

    Write("Enter your password: ");
    password = ReadLine();

} while (password != actualPassword);

WriteLine(count == 4? "\nError to many attempts": "Correct!");

#endregion