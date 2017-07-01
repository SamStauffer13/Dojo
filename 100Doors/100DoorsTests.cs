
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentAssertions;

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

[TestClass]
public class Tests
{
    [TestMethod]
    public void ToogleDoorsWillReturnTheSameAmountOfDoorsPassedIn()
    {
        var toggledDoors = DoorMan.ToggleDoors(new bool[100]);
        toggledDoors.Should().HaveCount(100);
    }

    [TestMethod]
    public void OnTheFirstPassToggleDoorsWillOpenAllTheDoors()
    {
        var doors = new bool[100];
        var toggledDoors = DoorMan.ToggleDoors(doors);

        for (var i = 0; i < 100; i++)
        {
            var door = toggledDoors[i];
            door.Should().BeTrue($"door #{i} should be open");
        }
    }

    [TestMethod]
    public void OnTheSecondPassToggleDoorsWillCloseEveryOtherDoor()
    {
        var doors = new bool[100];
        var toggledDoors = DoorMan.ToggleDoors(doors, 2);
        for (var i = 1; i < 100; i++)
        {
            var door = toggledDoors[i - 1];
            if (i % 2 == 0)
            {
                door.Should().BeFalse($"door #{i} should be closed");
            }
            else
            {
                door.Should().BeTrue($"door #{i} should be open");
            }
        }
    }
}