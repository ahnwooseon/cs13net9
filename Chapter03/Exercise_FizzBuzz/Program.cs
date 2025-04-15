for (int i = 1; i <= 100; i++)
{
    string value = i switch
    {
        _ when i % 3 == 0 && i % 5 == 0 => "FizzBuzz",
        _ when i % 3 == 0 => "Fizz",
        _ when i % 5 == 0 => "Buzz",
        _ => i.ToString(),
    };

    Write($"{value}, ");

    if (i % 10 == 0)
    {
        WriteLine();
    }
}
