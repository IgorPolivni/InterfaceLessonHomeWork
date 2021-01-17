using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    //Бригада строителей
    public class Team
    {
        //Бригадир
        public TeamLeader teamLeader { get; set; }

        //Массив работников
        public Worker[] workers { get; set; }

        //Начать работу
        public void StartWorking(House house)
        {
            while (true) {
                if (!teamLeader.isBuilt(house))
                {
                    int[] report = teamLeader.GenerateReport(house);

                    IPart part = teamLeader.NextPartForConstruction(report);

                    int TimeForConstruction = CalculateTime(workers, part);
                    DateTime endTime = DateTime.Now.AddSeconds(TimeForConstruction);

                    Menu.PrintConstructionProgress(part, endTime);

                    house.Parts.Add(part);
                }
                else
                {
                    Menu.EndConstraction();
                    Menu.PrintHouse(house);
                    break;
                } 

            }
        }



        public static int CalculateTime(Worker[] workers, IPart part)
        {
            if (workers.Length == 0)
                throw new Exception("Количество рабочих равняется нулю!");
            int TimeForConstruction = part.GetTimeForConstruction - workers.Length + 1;
            if (TimeForConstruction < 1)
                TimeForConstruction = 1;
            return TimeForConstruction;
        }
    }
}
