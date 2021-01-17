using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork.PracticalWork
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public double GetAvgGrade()
        {
            int sum = new int();
            for (int i = 0;i< Grades.Length; i++)
            {
                sum += Grades[i];
            }
            return sum / Grades.Length;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
