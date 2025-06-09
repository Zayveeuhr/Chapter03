//using static System.Convert; // To use the ToInt32 method. but I decided to add this globally in the .csproj 
using System.Globalization;// To use CultureInfo

#region Casting int to double

using System.Buffers.Text;
using System.Reflection;

int a = 10;
double b = a; // An int can be safely cast into a double.
WriteLine($"a is {a}, b is {b}");

double c = 9.8;
int d = (int)c; // Compiler gives an error if you do not explicitly cast.
WriteLine($"c is {c}, d is {d}"); // d loses the .8 part.

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

#endregion

#region Negitive numbers repesented in bianary

WriteLine("\n\n{0,12} {1,34}", "Decimal", "Binary");
WriteLine("{0,12} {0,34:B32}", int.MaxValue);

for (int i = 8; i >= -8; i--)
{
    WriteLine("{0,12} {0,34:B32}", i);
}

WriteLine("{0,12} {0,34:B32}", int.MinValue);


WriteLine();

long r = 0b_101000101010001100100111010100101010;
int s = (int)r;

WriteLine($"{r,38:B38} = {r}");
WriteLine($"{s,38:B38} = {s}");

#endregion

#region Converting with the System.Convert type

WriteLine();

double g = 9.8;
int h = ToInt32(g); // A method of System.Convert.

WriteLine($"g is {g}, h is {h}");

#endregion

#region Rounding Numbers

WriteLine();

double[,] doubles =
{
    { 9.49, 9.5, 9.51 },
    { 10.49, 10.5, 10.51 },
    { 11.49, 11.5, 11.51 },
    { 12.49, 12.5, 12.51 },
    { -12.49, -12.5, -12.51 },
    { -11.49, -11.5, -11.51 },
    { -10.49, -10.5, -10.51 },
    { -9.49, -9.5, -9.51 },
};

WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");

for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Write($"| {doubles[x, y],6} | {ToInt32(doubles[x, y]),7} ");
    }
    WriteLine("|");
}
WriteLine();

#endregion

#region Taking control of rounding rules

WriteLine();

foreach (double n in doubles)
{
    WriteLine("Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}", 
        arg0: n,
        arg1: Math.Round( value: n, digits: 0, 
            mode: MidpointRounding.AwayFromZero));
}

#endregion

#region Converting from any type to a string
WriteLine();
int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new();
WriteLine(me.ToString());

#endregion

#region Converting from a bianry object to a string

WriteLine();
// Allocate an array of 128 bytes.
byte[] binaryObject = new byte[128];

// Populate the array with random bytes
Random.Shared.NextBytes(binaryObject);

WriteLine("Binary object as bytes");
for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:x2} ");
}
WriteLine();

// Convert the array to base64 string and output as text.
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary object as base64: {encoded}");

#endregion

#region Parsing from strings to numbers or dates and times

// Set the current culture to make sure data parsing works.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
WriteLine();
int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("4 june 1980");
WriteLine($"I have {friends} friends to invite to my party.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}");

#endregion

#region Avoiding exceptiions by using the tryParse method

WriteLine();

Write("How many eggs are there? ");
string? input = ReadLine();

WriteLine(int.TryParse(input, out int count) ? $"There are {count} eggs." : "I could not parse the input");

#endregion