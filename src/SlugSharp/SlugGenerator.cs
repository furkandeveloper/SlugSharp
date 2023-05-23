using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Unidecode.NET;

namespace SlugSharp;

public static class SlugGenerator
{
    public static string Generate(IEnumerable<string> inputStrings)
    {
        var outputStrings = (from inputString in inputStrings
            select (inputString.Unidecode().ToLowerInvariant())
            into slug
            select Regex.Replace(slug, @"[^a-z0-9\s-]", string.Empty)
            into slug
            select Regex.Replace(slug, @"\s+", " ").Trim()
            into slug
            select Regex.Replace(slug, @"\s", "-")
            into slug
            select slug.ToLower()).ToList();

        return string.Join("-", outputStrings);
    }

    public static string Generate(string inputString)
    {
        return Generate(new[] { inputString });
    }
}