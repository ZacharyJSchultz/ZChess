using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ZChess.GenFiles
{
    public static class HelperFunctions
    {
        // AI-generated w/ ChatGPT
        public static string ToKebabCase(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            bool isEnum = value.Length > 1
                && value[0] == 'e'
                && char.IsUpper(value[1]);

            if (isEnum)
                value = value.Substring(1);

            bool isModel = value.EndsWith("Model", StringComparison.Ordinal);

            if (isModel)
                value = value.Substring(0, value.Length - "Model".Length);

            value = Regex.Replace(value, "([A-Z]+)([A-Z][a-z])", "$1-$2");
            value = Regex.Replace(value, "([a-z0-9])([A-Z])", "$1-$2");

            return value.ToLowerInvariant() +
                   (isEnum ? ".enum" : isModel ? ".model" : "");
        }

        public static string GetDotSlashes(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "./";
            }

            int count = value.Count(c => c == '.') - 1;
            if (count <= 0)
            {
                return "./";
            }
            else
            {
                return string.Concat(Enumerable.Repeat("../", count));
            }
        }
    }
}