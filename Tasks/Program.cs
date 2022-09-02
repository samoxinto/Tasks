using System;
using System.Linq;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи:");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 34: Task34(); break;
                case 36: Task36(); break;
                case 38: Task38(); break;
                case 41: Task41(); break;
                case 43: Task43(); break;
                default: break;
            }

            Console.ReadLine();
        }


        static void Task34()
        {
            var numbers = new int[5];

            var random = new Random();

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = random.Next(100, 999);
                Console.WriteLine(numbers[i]);
            }

            int counter = 0;

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

        }

        static void Task36()
        {
            var numbers = new int[4];

            var random = new Random();

            var sum = 0;

            for (int i = 0; i < 4; i++)
            {
                numbers[i] = random.Next(1, 100);
                Console.WriteLine(numbers[i]);

                if (i % 2 > 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }

        static void Task38()
        {
            var numbers = new double[] { 3, 7, 22, 2, 78 };

            Console.WriteLine(numbers.Max() - numbers.Min());

        }


        static void Task41()
        {
            Console.WriteLine("Введите количество чисел:");

            var count = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите {count} чисел");

            int counter = 0;

            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

        static void Task43()
        {
            Console.WriteLine("Введите b1:");
            double b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите k1:");
            double k1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите b2:");
            double b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите k2:");
            double k2 = int.Parse(Console.ReadLine());

            var y1 = k1 - k2;
            var y2 = b2 - b1;

            var x = y2 / y1;
            var y = k1 * x + b1;

            Console.WriteLine($"({x}, {y})");
        }
    }
}
