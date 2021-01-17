using System;

namespace InterfaceLessonHomeWork
{
    public class Menu
    {
        public static void PrintConstructionProgress(IPart part, DateTime endTime)
        {
            Console.Clear();
            Console.WriteLine($"Идет строительство - {part.GetName}...");
            while (true)
            {
                if (DateTime.Now >= endTime)
                    break;
            }
            Console.Clear();
            Console.WriteLine($"Строительство {part.GetName} завершено!");
            Console.WriteLine("Нажмите \"Enter\" для продолжения строительства!");
            Console.ReadLine();
        }

        internal static void PrintHouse(House house)
        {
            Console.WriteLine(house.DisplayHouse);
        }

        internal static void EndConstraction()
        {
            Console.Clear();
            Console.WriteLine("----------------Ваш дом построен----------------");
            Console.WriteLine("Спасибо, что выбрали нашу строительную компанию");
            Console.WriteLine("\nНажимете \"Enter\", чтобы посмотреть на свой дом");
            Console.ReadLine();
        }

        internal static int GetNumberWorkers()
        {
            int numberWorkers = new int();
            while (true)
            {
                Console.WriteLine("Для начала работы вам нужна бригада работников.");
                Console.WriteLine("Сколько рабочих вы хотите нанять (от числа работников зависит скорость работы):");
                int.TryParse(Console.ReadLine(), out numberWorkers);
                if (numberWorkers <= 0)
                {
                    Console.WriteLine("Вы ввели неправильное значение!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
            return numberWorkers;
        }
    }
}
