using System;

namespace Lab1_OOP_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(); //створення об'єкту
            try
            {
                while (true)
                {
                    Console.WriteLine("виберіть операцію: " + //меню у безкінечному циклі
                        " 0 - встановлення години" +
                        " 1 - встановлення хвилини" +
                        " 2 - встановлення секунди" +
                        " 3 - вихід з програми");
                    int opperation = Convert.ToInt16(Console.ReadLine());
                    switch (opperation)
                    {
                        case 0: //встановлення години
                            time.SetHour();
                            time.DisplayTime();
                            break;
                        case 1: //встановлення хвилин
                            time.SetMin();
                            time.DisplayTime();
                            break;
                        case 2: //встановлення секунд
                            time.SetSec();
                            time.DisplayTime();
                            break;
                        case 3: //вихід
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Помилка");
            }
        }
    }
}