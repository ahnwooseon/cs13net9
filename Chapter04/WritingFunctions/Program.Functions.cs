using System.Globalization; // To use CultureInfo.
using System.Linq.Expressions;

partial class Program
{
    #region Times table example

    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows:");
        WriteLine();

        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {number} = {row * number}");
        }
        WriteLine();
    }

    #endregion Times table example

    #region Writing a function that returns a value

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M, // Switzerland
            "DK" or "NO" => 0.25M, // Denmark, Norway
            "GB" or "FR" => 0.2M, // UK, France
            "HU" => 0.27M, // Hungary
            "OR" or "AK" or "MT" => 0.0M, // Oregon, Alaska, Montana
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M, // California
            _ => 0.06M // Most other states.
        };
        return amount * rate;
    }

    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        // To enable Unicode characters like Euro symbol in the console.
        OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
    }

    #endregion Writing a function that returns a value

    #region Converting numbers from cardinal to ordinal

    /// <summary>
    /// Pass a 32-bit unsigned integer and it will be converted to its ordinal equivalent.
    /// </summary>
    /// <param name="number">Number as a cardinal value e.g. 1, 2, 3, and so on.</param>
    /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;

        switch (lastTwoDigits)
        {
            case 11: // Special case for 11th to 13th.
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                uint lastDigit = number % 10;

                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };

                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinalToOrdinal()
    {
        for (uint number = 1; number <= 1500; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
        WriteLine();
    }

    #endregion Converting numbers from cardinal to ordinal

    #region Calculating factorials with recursion

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(
                $"The factorial function is defined for non-negative integers only. Input: {number}",
                nameof(number)
            );
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked // for overflow
            {
                return number * Factorial(number - 1);
            }
        }
    }

    static void RunFactorial()
    {
        for (int i = -2; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }

    #endregion Calculating factorials with recursion

    #region Using lambdas in function implementations

    static int FibImperative(uint term)
    {
        if (term == 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term - 1) + FibImperative(term - 2);
        }
    }

    static void RunFibImperative()
    {
        for (uint i = 1; i <= 30; i++)
        {
            WriteLine(
                "The {0} term of the Fibonacci sequence is {1:N0}",
                CardinalToOrdinal(i),
                FibImperative(i)
            );
        }
    }

    static int FibFunctional(uint term) => term switch
    {
        0 => throw new ArgumentOutOfRangeException(),
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term - 2)
    };

    static void RunFibFunctional()
    {
        for (uint i = 1; i <= 30; i++)
        {
            WriteLine(
                "The {0} term of the Fibonacci sequence is {1:N0}",
                CardinalToOrdinal(i),
                FibFunctional(i)
            );
        }
    }

    #endregion Using lambdas in function implementations
}
