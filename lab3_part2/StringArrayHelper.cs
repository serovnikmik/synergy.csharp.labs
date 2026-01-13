using System;

namespace lab3Serov.Part2
{
    public static class StringArrayHelper
    {
        private static Random random = new Random();

        public static int[] GenerateArray(int size, int min, int max)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }

        public static string GenerateString(int length)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }
            return new string(result);
        }

        public static string GenerateWord(int minLength, int maxLength)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            int length = random.Next(minLength, maxLength + 1);
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }
            return new string(result);
        }

        public static string ArrayToString(int[] array)
        {
            return "[" + string.Join(", ", array) + "]";
        }

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static int GenerateNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public static double[] GenerateDoubleArray(int size, double min, double max)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = min + (random.NextDouble() * (max - min));
            }
            return array;
        }
    }
}