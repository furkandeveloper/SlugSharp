using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SlugSharp;

public static class SlugGenerator
{
    public static string Generate(IEnumerable<string> inputStrings)
    {
        var outputStrings = (from inputString in inputStrings select RemoveTurkishChars(inputString) into slug select Regex.Replace(slug, @"[^a-z0-9\s-]", "") into slug select Regex.Replace(slug, @"\s+", " ").Trim() into slug select Regex.Replace(slug, @"\s", "-") into slug select slug.ToLower()).ToList();

        return string.Join("-", outputStrings);
    }

    private static string RemoveTurkishChars(string text)
    {
        var turkishChars = new Dictionary<string, string>
        {
            { "ı", "i" },
            { "ğ", "g" },
            { "ü", "u" },
            { "ş", "s" },
            { "ö", "o" },
            { "ç", "c" },
            { "İ", "i" },
            { "Ğ", "g" },
            { "Ü", "u" },
            { "Ş", "s" },
            { "Ö", "o" },
            { "Ç", "c" }
        };

        return turkishChars.Aggregate(text, (current, turkishChar) => current.Replace(turkishChar.Key, turkishChar.Value));
    }
}