using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    //Стены
    public class Wall: IPart
    {
        public string GetName { get; } = "Стена";
        public int GetTimeForConstruction { get; } = 5;
    }
}
