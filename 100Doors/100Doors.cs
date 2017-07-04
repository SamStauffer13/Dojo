using System;
using System.Linq;
using System.Collections.Generic;
public class DoorMan
{
    private bool[] doors;
    public DoorMan(int numberOfDoors)
    {
        doors = new bool[numberOfDoors];
    }
    public bool[] ToggleDoors(int loops)
    {
        for (var loop = 0; loop < loops; loop++)
        {
            // doors.Where((x, i) => (i + 1) % (loop + 1) == 0).ToList().ForEach(doors => doors = !doors);

            for (var doorLocation = 0; doorLocation < doors.Length; doorLocation++)
            {
                var isNthPosition = (doorLocation + 1) % (loop + 1) == 0;

                if (isNthPosition)
                {
                    doors[doorLocation] = !doors[doorLocation];
                }
            }
        }
        return doors;
    }
}