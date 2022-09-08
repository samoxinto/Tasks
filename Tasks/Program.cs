using System;
using System.Collections.Generic;
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
                case 47: Task47(); break;
                case 50: Task50(); break;
                case 52: Task52(); break;
                case 54: Task54(); break;
                case 56: Task56(); break;
                case 58: Task58(); break;
                case 60: Task60(); break;
                case 62: Task62(); break;
                case 64: Task64(); break;
                case 66: Task66(); break;
                case 68: Task68(); break;
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

        static void Task47()
        {
            int m = 3;
            int n = 4;

            var array = new double[m, n];

            var random = new Random();
            int min = -1;
            int max = 10;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * (max - min) + min, 1);
                }
            }

            for (int i = 0; i < m; i++)
            {
                var str = "";
                for (int j = 0; j < n; j++)
                {
                    str += array[i, j] + " ";
                }

                Console.WriteLine(str);
            }
        }

        static void Task50()
        {
            int m = 3;
            int n = 4;

            var array = new int[m, n];

            var random = new Random();

            for (int i = 0; i < m; i++)
            {
                var str = "";
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    str += array[i, j] + " ";
                }

                Console.WriteLine(str);
            }

            Console.WriteLine("Введите позицию элемента");
            int pos = int.Parse(Console.ReadLine());

            if (pos >= 0 && pos < m * n)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (pos == 0)
                        {
                            Console.WriteLine(array[i, j]);
                        }

                        pos--;
                    }
                }
            }
            else
                Console.WriteLine("Нет элемента с таким номером");
        }


        static void Task52()
        {
            int m = 3;
            int n = 4;

            var array = new int[m, n];

            var random = new Random();

            for (int i = 0; i < m; i++)
            {
                var str = "";
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    str += array[i, j] + " ";
                }

                Console.WriteLine(str);
            }

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += array[j, i];
                }

                Console.Write((sum / m) + " ");
            }
        }

        static void Task54()
        {
            int m = 3;
            int n = 4;

            var array = new int[m, n];

            var random = new Random();

            for (int i = 0; i < m; i++)
            {
                var str = "";
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    str += array[i, j] + " ";
                }

                Console.WriteLine(str);
            }

            void Sort(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    var list = new List<int>();

                    for (int j = 0; j < a.GetLength(1); j++)
                        list.Add(a[i, j]);

                    list.Sort();

                    for (int j = 0; j < list.Count; j++)
                        a[i, j] = list[j];
                }
            }

            Console.WriteLine();

            Sort(array);

            ShowArray(array);
        }

        static void Task56()
        {
            int m = 4;
            int n = 4;

            var array = new int[m, n];

            var random = new Random();

            for (int i = 0; i < m; i++)
            {
                var str = "";
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    str += array[i, j] + " ";
                }

                Console.WriteLine(str);
            }

            int min = int.MaxValue;
            int line = 0;

            for (int i = 0; i < m; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                    sum += array[i, j];

                if (sum < min)
                {
                    min = sum;
                    line = i;
                }
            }

            Console.WriteLine("Минимальная сумма на строке " + line);
        }


        static void Task58()
        {
            var a = new int[,] 
            { 
                { 2, 4 }, 
                { 3, 2 } 
            };

            var b = new int[,] 
            { 
                { 3, 4 }, 
                { 3, 3 } 
            };

            if (a.GetLength(1) != b.GetLength(0))
                throw new ArgumentException("Количество колонок в первой матрице должно совпадать с количеством строк во второй");

            var r = new int[a.GetLength(1), Math.Max(a.GetLength(0), b.GetLength(1))];

            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < b.GetLength(1); j++)
                    for (int k = 0; k < b.GetLength(0); k++)
                        r[i, j] += a[i, k] * b[k, j];

            ShowArray(r);
        }

        static void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                var str = "";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    str += array[i, j] + " ";
                }

                Console.WriteLine(str);
            }
        }


        static void Task60()
        {
            var a = new int[2, 2, 2];
            a[0, 0, 0] = 66;
            a[0, 1, 0] = 25;
            a[1, 0, 0] = 34;
            a[1, 1, 0] = 41;
            a[0, 0, 1] = 27;
            a[0, 1, 1] = 90;
            a[1, 0, 1] = 26;
            a[1, 1, 1] = 55;

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                        Console.WriteLine($"{a[i, j, k]} ({i}, {j}, {k})");
        }

        static void Task62()
        {
            int n = 4;
            int m = 6;

            var a = new int[n, m];

            int iBeg = 0;
            int iFin = 0;
            int jBeg = 0;
            int jFin = 0;

            int k = 1;
            int i = 0;
            int j = 0;

            while (k <= n * m)
            {
                a[i, j] = k;

                if (i == iBeg && j < m - jFin - 1) ++j;
                else if (j == m - jFin - 1 && i < n - iFin - 1) ++i;
                else if (i == n - iFin - 1 && j > jBeg) --j;
                else --i;

                if((i == iBeg + 1) && (j == jBeg) && (jBeg != m - jFin - 1))
                {
                    ++iBeg;
                    ++iFin;
                    ++jBeg;
                    ++jFin;
                }
                ++k;
            }

            ShowArray(a);
        }

        static void Task64()
        {
            int m = 1;
            int n = 5;

            for (int i = m; i <= n; i++)
                Console.Write(i + " ");
        }

        static void Task66()
        {
            int m = 1;
            int n = 15;
            int sum = 0;

            for (int i = m; i <= n; i++)
                sum += i;

            Console.WriteLine(sum);
        }

        static void Task68()
        {
            int m = 2;
            int n = 3;

            Console.WriteLine(Akk(m, n));
        }

        static int Akk(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (m > 0 && n == 0)
                return Akk(m - 1, 1);
            else
            return Akk(m - 1, Akk(m, n - 1));
        }






    }
}
