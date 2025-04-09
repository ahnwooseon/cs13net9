﻿using static System.Convert; // To use the ToInt32 method.
# region Casting numbers implicitly and explicitly

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

# endregion

# region How negative numbers are represented in binary

WriteLine("{0,12} {1,34}", "Decimal", "Binary");
WriteLine("{0,12} {0,34:B32}", int.MaxValue);
for (int i = 8; i >= -8; i--)
{
    WriteLine("{0,12} {0,34:B32}", i);
}
WriteLine("{0,12} {0,34:B32}", int.MinValue);

long r = 0b_101000101010001100100111010100101010;
int s = (int)r;

Console.WriteLine($"{r, 38:B38} = {r}");
Console.WriteLine($"{s, 38:B32} = {s}");

# endregion

# region Converting with the System.Convert type

double g = 9.8;
int h = ToInt32(g); // A method of System.Convert.
WriteLine($"g is {g}, h is {h}");

# endregion

# region Rounding numbers and the default rounding rules

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
        Write($"| {doubles[x, y], 6} | {ToInt32(doubles[x, y]), 7} ");
    }
    WriteLine("|");
}
WriteLine();

# endregion

# region Taking control of rounding rules

foreach (double n in doubles)
{
    WriteLine(
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        n,
        Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero)
    );
}

# endregion
