try
{
    Write("Enter a number between 0 and 255: ");
    string firstEntry = ReadLine()!;
    byte firstNumber = byte.Parse(firstEntry);

    Write("Enter another number between 0 and 255: ");
    string secondEntry = ReadLine()!;
    byte secondNumber = byte.Parse(secondEntry);

    WriteLine($"{firstNumber} divided by {secondNumber} is {firstNumber / secondNumber}");
}
catch (OverflowException)
{
    WriteLine("The number you entered is too large.");
}
catch (FormatException ex)
{
    WriteLine(ex.Message);
    WriteLine("The number you entered is not in the correct format.");
}
catch (DivideByZeroException)
{
    WriteLine("You cannot divide by zero.");
}
catch (Exception ex)
{
    WriteLine($"An unexpected error occurred: {ex.Message}");
}
