using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    public interface IPart
    {
        //Возвращает название части
        public string GetName { get; }

        //Возвращает время для стрительства
        public int GetTimeForConstruction { get; }

    }
}
