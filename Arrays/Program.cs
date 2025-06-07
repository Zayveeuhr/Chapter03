#region Single-dimensional arrays

string[] names; // This can reference any siz array of strings.

// Allocate memory for four strings in an array.
names = new string[4];

// Store items at these index positions.
names[0] = "kate";
names[1] = "jake";
names[2] = "Rebecca";
names[3] = "Tom";

// Alternative syntax for creating and initializing an array.
string[] names2 = { "kate", "jake", "Rebecca", "Tome" };

// Loop through the names.
for (int i = 0; i < names2.Length; i++)
{
    //Output the item at index position i.
    WriteLine($"{names2[i]} is at postion {i}");
}
WriteLine();

#endregion

#region Working with multi-dimensional arrays

string[,] grid1 = // Two dimensional array.
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Silver", "Gold", "Diamond", "Master" }
};

WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, Upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2st dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2st dimension, Upper bound: {grid1.GetUpperBound(1)}");
WriteLine();

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}
#endregion

#region Working with jagged arrays

string[][] jagged = // An array of string arrays.
{
    ["Alpha", "Beta", "Gamma"], // Also = new[] {"Alpha", "Beta", "Gamma"}
    ["Anne", "ben", "Charlie", "Doug"],
    ["Avardvark", "Bear"]
};

WriteLine("\n\nUpper bound of the array of arrays is: {0}", jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
    WriteLine("Upper bound of array {0} is: {1}", arg0: array, arg1: jagged[array].GetUpperBound(0));
}

WriteLine();

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
    for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
    {
        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
    }
}

#endregion

#region List pattern mataching with arrays

int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = { 1, 2 };
int[] oneTwoTenNumbers = { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = { 0, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = Array.Empty<int>(); // or use { };
int[] threeNumbers = { 9, 7, 5 };
int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };

WriteLine();
WriteLine($"{nameof(sequentialNumbers)}: {CheckingSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckingSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckingSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckingSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckingSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckingSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckingSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckingSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckingSwitch(sixNumbers)}");



static string CheckingSwitch(int[] values) => values switch
{
    [] => "Empty array",
    [1, 2, _, 10] => "Contains 1,2, any single number, 10.",
    [1, 2, .., 10] => "Contains 1,2 any rang including empty, 10.",
    [1, 2] => "Contains 1,2.",
    [int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}.",
    [0, _] => "Starts with 0, then one other number.",
    [0, ..] => "Starts with 0, then any rang of numbers.",
    [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
    [..] => "Any items in any order.", // <-- Note the trailing comma for easier re-ordering.
    // Use alt + up or down arrow to move statements.
};

#endregion