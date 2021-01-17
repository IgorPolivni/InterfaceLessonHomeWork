using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    //Крыша
    public class Roof : IPart
    {
        public string GetName { get; } = "Потолок";
        public int GetTimeForConstruction { get; } = 10;
    }
}
