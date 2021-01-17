using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLessonHomeWork
{
    //Бригадир
    public class TeamLeader : IWorker
    {
        public int[] GenerateReport(House house)
        {
            int[] numberParts = GetHouseProgress(house.Parts);

            for (int i = 0; i< House.numberElements; i++)
            {
                if (numberParts[i] > House.numberPartsPerProject[i])
                    throw new Exception("Неверные параметры дома!");
            }
            return numberParts;
        }

        public int[] GetHouseProgress(List<IPart> houseParts)
        {
            int[] numberParts = new int[House.numberElements];

            foreach (IPart part in houseParts)
            {
                if (part is Basement)
                    numberParts[(int)Parts.Basement]++;
                else if (part is Wall)
                    numberParts[(int)Parts.Wall]++;
                else if (part is Door)
                    numberParts[(int)Parts.Door]++;
                else if (part is Window)
                    numberParts[(int)Parts.Window]++;
                else if (part is Roof)
                    numberParts[(int)Parts.Roof]++;
            }

            return numberParts;
        }

        public IPart NextPartForConstruction(int[] report)
        {
            for (int i = 0; i < House.numberElements; i++)
            {
                if (report[i] < House.numberPartsPerProject[i])
                {
                    return Service.ValueAsClass(i);
                }
                    
            }
            throw new Exception("Дом уже готов!");
        }

        public bool isBuilt(House house)
        {
            int[] numberParts = GetHouseProgress(house.Parts);
            if (Service.isEquals(numberParts, House.numberPartsPerProject))
                return true;
            else
                return false;
        }

    }
}
