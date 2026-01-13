using System;
using System.IO;
using System.Text;

namespace lab2Serov
{
    public static class ExtendedGenerator
    {
        private static Random random = new Random();

        public static int GenerateOddNumber(int min, int max)
        {
            int number;
            do
            {
                number = random.Next(min, max + 1);
            } while (number % 2 == 0);
            return number;
        }

        public static void CreateNumberFile(string filename, int count, int min, int max)
        {
            string projectPath = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(projectPath, filename);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                for (int i = 0; i < count; i++)
                {
                    writer.WriteLine(random.Next(min, max + 1));
                }
            }
        }

        public static double[] GenerateNDimensionalPoint(int dimensions, double min, double max)
        {
            double[] point = new double[dimensions];
            for (int i = 0; i < dimensions; i++)
            {
                point[i] = min + (random.NextDouble() * (max - min));
            }
            return point;
        }

        public static string GenerateMixedCaseText(int length)
        {
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                if (random.Next(2) == 0)
                {
                    text.Append((char)random.Next('a', 'z' + 1));
                }
                else
                {
                    text.Append((char)random.Next('A', 'Z' + 1));
                }
            }
            return text.ToString();
        }

        public static (double x, double y) GeneratePoint2D(double min, double max)
        {
            double x = min + (random.NextDouble() * (max - min));
            double y = min + (random.NextDouble() * (max - min));
            return (x, y);
        }

        public static (double side, double angle1, double angle2) GenerateTriangle()
        {
            double side = random.Next(5, 20);
            double angle1 = random.Next(30, 60);
            double angle2 = random.Next(30, 60);
            return (side, angle1, angle2);
        }

        public static int GenerateThreeDigitNumber()
        {
            return random.Next(100, 1000);
        }

        public static int GenerateTwoDigitNumber()
        {
            return random.Next(10, 100);
        }

        public static int GenerateYear()
        {
            return random.Next(1900, 2101);
        }

        public static double Function1(double x)
        {
            return x * x - 2 * x + 1;
        }

        public static double Function2(double x)
        {
            return Math.Sin(x) + Math.Cos(x);
        }

        public static double Function3(double x)
        {
            if (x < 0) return x * x;
            else if (x >= 0 && x <= 5) return x + 1;
            else return 2 * x - 1;
        }

        public static int GenerateNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public static double[] Generate1DDoubleArray(int size, double minValue, double maxValue)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = minValue + (random.NextDouble() * (maxValue - minValue));
            }
            return array;
        }

        public static void CreateTestFiles()
        {
            string[] testFiles = { "test1.txt", "test2.txt", "test3.txt" };

            foreach (string file in testFiles)
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), file);
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    writer.WriteLine("Тестовый файл: " + file);
                    for (int i = 0; i < 5; i++)
                    {
                        writer.WriteLine("Строка " + (i + 1));
                    }
                }
            }
        }
    }
}