using System.Xml;

WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
    WriteLine(arg);
}

if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // Stop running.
}

ForegroundColor = Enum.Parse<ConsoleColor>(args[0], true);

BackgroundColor = Enum.Parse<ConsoleColor>(args[1], true);

CursorSize = int.Parse(args[2]);
