using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    public class Door : IPart
    {
        public string GetName { get; } = "Дверь";
        public int GetTimeForConstruction { get; } = 5;
    }
}
