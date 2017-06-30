
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

// 100 doors in a row are all initially closed. You make
// 100 passes by the doors. The first time through, you
// visit every door and toggle the door (if the door is
// closed, you open it; if it is open, you close it).
// The second time you only visit every 2nd door (door
// #2, #4, #6, ...). The third time, every 3rd door
// (door #3, #6, #9, ...), etc, until you only visit
// the 100th door.

// Question: What state are the doors in after the last
// pass? Which are open, which are closed?

// [Source http://rosettacode.org]

// https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
[TestClass]
public class Tests
{
    [TestMethod]
    public void ToggleDoorsReturnsAnArray()
    {
        var doors = DoorMan.ToggleDoors();

        Assert.AreEqual(true, false);
    }
}