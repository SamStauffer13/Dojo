using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentAssertions;

// Write a program to generate all potential 
// anagrams of an input string.

// For example, the potential anagrams of "biro" are

// biro bior brio broi boir bori
// ibro ibor irbo irob iobr iorb
// rbio rboi ribo riob roib robi
// obir obri oibr oirb orbi orib

[TestClass]
public class ScrabblerSpecs
{
    [TestMethod]
    public void ScrabbleDeterminesAllPotentialAnagramsOfAWord()
    {
        var words = "biro".Scrabble();

        var possibleVariations = new[] {
            "biro", "bior", "brio", "broi",
            "boir", "bori", "ibro", "ibor",
            "irbo", "irob", "iobr", "iorb",
            "rbio", "rboi", "ribo", "riob",
            "roib", "robi", "obir", "obri",
            "oibr", "oirb", "orbi", "orib"
            };

        words.Should().Equal(possibleVariations);
    }
}