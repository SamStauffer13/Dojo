using System;

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
            for (var i = 0; i < doors.Length; i++)
            {
                var isNthPosition =  (i + 1) % (loop + 1) == 0;

                if (isNthPosition)
                {
                    doors[i] = !doors[i];
                }
            }
        }
        return doors;
    }
}