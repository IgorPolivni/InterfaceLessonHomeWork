using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    public class Window : IPart
    {
        public string GetName { get; } = "Окно";
        public int GetTimeForConstruction { get; } = 5;
    }
}
