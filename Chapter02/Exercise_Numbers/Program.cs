WriteLine(new string('-', 106));
Write("{0, -8}", "Type");
Write("{0}", "Byte(s) of memory");
Write("{0, 33}", "Min");
WriteLine("{0, 48}", "Max");
WriteLine(new string('-', 106));

Write("{0,-8}", "sbyte");
Write("{0, -2}", sizeof(sbyte));
Write("{0, 48}", sbyte.MinValue);
WriteLine("{0, 48}", sbyte.MaxValue);

Write("{0,-8}", "byte");
Write("{0, -2}", sizeof(byte));
Write("{0, 48}", byte.MinValue);
WriteLine("{0, 48}", byte.MaxValue);

Write("{0,-8}", "short");
Write("{0, -2}", sizeof(short));
Write("{0, 48}", short.MinValue);
WriteLine("{0, 48}", short.MaxValue);

Write("{0,-8}", "ushort");
Write("{0, -2}", sizeof(ushort));
Write("{0, 48}", ushort.MinValue);
WriteLine("{0, 48}", ushort.MaxValue);

Write("{0,-8}", "int");
Write("{0, -2}", sizeof(int));
Write("{0, 48}", int.MinValue);
WriteLine("{0, 48}", int.MaxValue);

Write("{0,-8}", "uint");
Write("{0, -2}", sizeof(uint));
Write("{0, 48}", uint.MinValue);
WriteLine("{0, 48}", uint.MaxValue);

Write("{0,-8}", "long");
Write("{0, -2}", sizeof(long));
Write("{0, 48}", long.MinValue);
WriteLine("{0, 48}", long.MaxValue);

Write("{0,-8}", "ulong");
Write("{0, -2}", sizeof(ulong));
Write("{0, 48}", ulong.MinValue);
WriteLine("{0, 48}", ulong.MaxValue);

unsafe
{
    Write("{0,-8}", "Int128");
    Write("{0, -2}", sizeof(Int128));
    Write("{0, 48}", Int128.MinValue);
    WriteLine("{0, 48}", Int128.MaxValue);

    Write("{0,-8}", "UInt128");
    Write("{0, -2}", sizeof(UInt128));
    Write("{0, 48}", UInt128.MinValue);
    WriteLine("{0, 48}", UInt128.MaxValue);

    Write("{0,-8}", "Half");
    Write("{0, -2}", sizeof(Half));
    Write("{0, 48}", Half.MinValue);
    WriteLine("{0, 48}", Half.MaxValue);
}

Write("{0,-8}", "float");
Write("{0, -2}", sizeof(float));
Write("{0, 48}", float.MinValue);
WriteLine("{0, 48}", float.MaxValue);

Write("{0,-8}", "double");
Write("{0, -2}", sizeof(double));
Write("{0, 48}", double.MinValue);
WriteLine("{0, 48}", double.MaxValue);

Write("{0,-8}", "decimal");
Write("{0, -2}", sizeof(decimal));
Write("{0, 48}", decimal.MinValue);
WriteLine("{0, 48}", decimal.MaxValue);
