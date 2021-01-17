using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    //Фундамент
    public class Basement : IPart
    {
        public string GetName { get; } = "Фундамент";

        public int GetTimeForConstruction { get; } = 10;

    }
}
