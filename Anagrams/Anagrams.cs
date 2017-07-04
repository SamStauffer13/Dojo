using System.Collections.Generic;
using System.Linq;
using System;
public static class Scrabbler
{
    // https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer       
    public static ICollection<string> Scrabble(this string word)
    {
        var characters = word.ToCharArray();
        var lengthOfWord = characters.Length - 1;
        var permutations = new List<string>();
        RecursivelyGetPermutations(characters, lengthOfWord, permutations);
        return permutations;
    }

    private static void RecursivelyGetPermutations(char[] list, int lengthOfWord, List<string> permutations, int indexOfCharacter = 0)
    {
        if (indexOfCharacter == lengthOfWord)
        {
            permutations.Add(new string(list));
            Console.WriteLine(list);
        }
        else for (int indexOfNextCharacter = indexOfCharacter; indexOfNextCharacter <= lengthOfWord; indexOfNextCharacter++)
        {
            var currentCharacter = list[indexOfCharacter];
            var nextCharacter = list[indexOfNextCharacter];

            list[indexOfCharacter] = nextCharacter;
            list[indexOfNextCharacter] = currentCharacter;

            RecursivelyGetPermutations(list, lengthOfWord, permutations, indexOfCharacter + 1);
        }
    }
}