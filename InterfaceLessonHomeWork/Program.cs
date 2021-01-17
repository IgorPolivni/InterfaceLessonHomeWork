using System;
using System.Collections.Generic;

namespace InterfaceLessonHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberWorkers = Menu.GetNumberWorkers();

            House house = new House()
            {
                Parts = new List<IPart> {}
            };
            Team team = new Team()
            {
                teamLeader = new TeamLeader(),
                workers = Service.WorkerArrayFilling(numberWorkers)
            };

            team.StartWorking(house);

        }

    }
}
