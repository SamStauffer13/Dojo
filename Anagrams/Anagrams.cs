using System.Collections.Generic;
using System.Linq;
public static class Scrabbler
{
    public static string[] Scrabble(this string word)
    {
        var chars = word.ToList();

        // if (chars.Count == 2) return new[] { word, string.Concat( chars.Reverse() ) };

        for (var i = 0; i < chars.Count; i++)
        {

        }

        return new string[] { };
    }
}