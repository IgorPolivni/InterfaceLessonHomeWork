using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    public class Service
    {
        public static IPart ValueAsClass(int value)
        {
            switch (value)
            {
                case (int)Parts.Basement:
                    return new Basement();
                case (int)Parts.Wall:
                    return new Wall();
                case (int)Parts.Door:
                    return new Door();
                case (int)Parts.Window:
                    return new Window();
                case (int)Parts.Roof:
                    return new Roof();
            }
            throw new Exception("Неправлиьное значение!");
        }

        internal static Worker[] WorkerArrayFilling(int sizeArray)
        {
            Worker[] workers = new Worker[sizeArray];
            for (int i = 0;i< sizeArray; i++)
            {
                workers[i] = new Worker();
            }
            return workers;
        }

        public static bool isEquals(int[] fArray, int[] sArray)
        {
            for (int i = 0;i< fArray.Length; i++)
            {
                if (fArray[i] != sArray[i])
                    return false;
            }
            return true;
        }
    }
}
