using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hunger level (1-10): ");
            int hunger = int.Parse(Console.ReadLine());

            if (hunger >= 8)
                Console.WriteLine("Lion: Roar! I need a big meal!");
            else if (hunger >= 5)
                Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
            else
                Console.WriteLine("Tortoise: Slow and steady I'll have some lettuce.");

            Console.WriteLine(hunger >= 8
                ? "Listen to the Lion: Roar!"
                : "Listen to the Monkey: Ooh ooh!");

            Console.Write("Enter day (1-7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Sunday: Relax at the zoo."); break;
                case 2: Console.WriteLine("Monday: A fresh start at the zoo."); break;
                case 3: Console.WriteLine("Tuesday: Enjoy the exhibits."); break;
                case 4: Console.WriteLine("Wednesday: Midweek at the zoo."); break;
                case 5: Console.WriteLine("Thursday: Special shows today."); break;
                case 6: Console.WriteLine("Friday: Get ready for the weekend."); break;
                case 7: Console.WriteLine("Saturday: Family day at the zoo."); break;
                default: Console.WriteLine("Invalid day."); break;
            }
        }
    }
}


