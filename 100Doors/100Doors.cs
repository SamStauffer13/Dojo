public static class DoorMan
{
    public static bool[] ToggleDoors(bool[] doors, int numberOLoops = 1)
    {
        for(var loops = 0; loops < numberOLoops; loops++)
        {
            for(var i = 0; i < doors.Length; i++)
            {            
                var door = doors[i];
                doors[i] = !door;
            }
        }

        return doors;
    }
}