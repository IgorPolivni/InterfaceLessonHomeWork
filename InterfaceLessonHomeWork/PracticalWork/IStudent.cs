﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork.PracticalWork
{
    interface IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }
        public string GetName();
        public string GetFullName();
        public double GetAvgGrade();
    }
}
