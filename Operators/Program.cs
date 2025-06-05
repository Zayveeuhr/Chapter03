#region Exploring unary operators

using System.Runtime.InteropServices.Marshalling;

int a = 3;
int b = a++; // Postfix means increment a before assigning it.
WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c; // Prefix means increment c before assigning it.
WriteLine($"a is {c}, b is {d}");

int e = 12;
int f = 5;
WriteLine($"\n\ne is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");


double g = 11.0;

WriteLine($"\ng is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

#endregion

#region Exploring logical operators

bool p = true;
bool q = false;

WriteLine($"\n\nAND   | p    | q    ");
WriteLine($"p     |{p & p,-5} |{p & q,-5}    ");
WriteLine($"q     |{q & p,-5} |{q & q,-5}    ");
WriteLine();
WriteLine($"OR    | p    | q    ");
WriteLine($"p     |{p | p,-5} |{p | q,-5}    ");
WriteLine($"q     |{q | p,-5} |{q | q,-5}    ");
WriteLine();
WriteLine($"XOR   | p    | q    ");
WriteLine($"p     |{p ^ p,-5} |{p ^ q,-5}    ");
WriteLine($"q     |{q ^ p,-5} |{q ^ q,-5}    ");

#endregion

#region Exploring conditional logical operators

WriteLine();
// Note that DoStuff() returns true.
WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");

WriteLine();
// Note that DoStuff() returns true.
WriteLine($"p && DoStuff() = {p && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");
static bool DoStuff()
{
    WriteLine("I am doing some stuff");
    return true;
}



#endregion

#region Exploring bitwise  amd binary shift operators

int x = 10;
int y = 6;

WriteLine($"\n\nExpression | Decimal |   Binary");
WriteLine($"_______________________________");
WriteLine($"x          | {x,7} | {x:B8}");
WriteLine($"x          | {y,7} | {y:B8}");
WriteLine($"x & y      | {x & y,7} | {x & y:B8}");
WriteLine($"x | y      | {x | y,7} | {x | y:B8}");
WriteLine($"x ^ y      | {x ^ y,7} | {x ^ y:B8}");

// Left-shift x by three bit columns.
WriteLine($"\n\nx << 3       | {x << 3,7} | {x << 3:B8}");

// Multiply x by 8.
WriteLine($"x * 8        | {x * 8,7} | {x * 8:B8}");

// Right-shift y by one bit column.
WriteLine($"y >> 1       | {y >> 1,7} | {y >> 1:B8}");

#endregion

#region Miscellaneous operators

int age = 50;

WriteLine($"\n\nThe {nameof(age)} variable uses {sizeof(int)} bytes of memory");

// How many operators in the following statement?
char firstDigit = age.ToString()[0];

// There are four operators 
// = is the assignment operator
// . is the member class operator
// () is the invocation operator
// [] is the index access operator

#endregion