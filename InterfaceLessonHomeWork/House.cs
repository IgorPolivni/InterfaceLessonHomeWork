using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    public class House
    {
        //Количество всех составных элементов дома
        public const int numberElements = 5;

        //Количество каждой части по проекту
        public static int[] numberPartsPerProject { get; } = new int[numberElements]
        {
            1,//Фундамент
            4,//Стены
            1,//Дверь
            4,//Окна
            1 //Крыша
        };


        public List<IPart> Parts { get; set; }

        //Отображение дома
        public string DisplayHouse { get; } = 
            "     _______________\n"+
            "    /\\              \\\n" +
            "   /  \\              \\\n" +
            "  /    \\              \\\n" +
            " /      \\              \\\n" +
            "/________\\ _____________\\\n" +
            "|   __   |      __      |\n" +
            "|  |  |  |     |  |     |\n" +
            "|  |  |  |     |__|     |\n" +
            "|__|__|__|______________|\n" +
            "|_/___/_________________|\n";
    }
}
