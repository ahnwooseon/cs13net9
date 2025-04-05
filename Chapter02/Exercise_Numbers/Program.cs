using Spectre.Console;

Table table = new();

table.AddColumn("Type");
table.AddColumn("Byte(s) of memory");
table.AddColumn("Min");
table.AddColumn("Max");

table.Columns[2].RightAligned();
table.Columns[3].RightAligned();

table.AddRow(
    "sbyte",
    sizeof(sbyte).ToString(),
    sbyte.MinValue.ToString(),
    sbyte.MaxValue.ToString()
);

table.AddRow("byte", sizeof(byte).ToString(), byte.MinValue.ToString(), byte.MaxValue.ToString());

table.AddRow(
    "short",
    sizeof(short).ToString(),
    short.MinValue.ToString(),
    short.MaxValue.ToString()
);

table.AddRow(
    "ushort",
    sizeof(ushort).ToString(),
    ushort.MinValue.ToString(),
    ushort.MaxValue.ToString()
);

table.AddRow("int", sizeof(int).ToString(), int.MinValue.ToString(), int.MaxValue.ToString());

table.AddRow("uint", sizeof(uint).ToString(), uint.MinValue.ToString(), uint.MaxValue.ToString());

table.AddRow("long", sizeof(long).ToString(), long.MinValue.ToString(), long.MaxValue.ToString());

table.AddRow(
    "ulong",
    sizeof(ulong).ToString(),
    ulong.MinValue.ToString(),
    ulong.MaxValue.ToString()
);

unsafe
{
    table.AddRow(
        "Int128",
        sizeof(Int128).ToString(),
        Int128.MinValue.ToString(),
        Int128.MaxValue.ToString()
    );

    table.AddRow(
        "UInt128",
        sizeof(UInt128).ToString(),
        UInt128.MinValue.ToString(),
        UInt128.MaxValue.ToString()
    );

    table.AddRow(
        "Half",
        sizeof(Half).ToString(),
        Half.MinValue.ToString(),
        Half.MaxValue.ToString()
    );
}

table.AddRow(
    "float",
    sizeof(float).ToString(),
    float.MinValue.ToString(),
    float.MaxValue.ToString()
);

table.AddRow(
    "double",
    sizeof(double).ToString(),
    double.MinValue.ToString(),
    double.MaxValue.ToString()
);

table.AddRow(
    "decimal",
    sizeof(decimal).ToString(),
    decimal.MinValue.ToString(),
    decimal.MaxValue.ToString()
);

AnsiConsole.Write(table);
