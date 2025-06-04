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