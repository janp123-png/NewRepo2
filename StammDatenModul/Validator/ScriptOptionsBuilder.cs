using System;
using System.Linq;

public static class DynamicHelpers
{
    public static bool AllDigits(string s) => s != null && s.All(char.IsDigit);
    public static bool IsNullOrWhiteSpace(string s) => string.IsNullOrWhiteSpace(s);
}
