using System;

namespace  Kolokwium2
{
	public class Task
    {
        public static bool IsPerfect(int number) // ZAD1
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum = sum + i;
            }

            if (sum == number)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static void PossibleCombinations() // ZAD2
        {
            for (int pln1 = 0; pln1 <= 10; pln1++)
                for (int pln2 = 0; pln2 <= 5; pln2++)
                    for (int pln5 = 0; pln5 <= 2; pln5++)
                        if (pln1 * 1 + pln2 * 2 + pln5 * 5 == 10)
                            Console.WriteLine($"1zł * {pln1}, 2zł * {pln2}, 5zł * {pln5}");
        }

        public static int[] RandomArray(int arrayLength) // ZAD3 f pomocnicza
        {
            int[] arr = new int[arrayLength];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(-100, 100);
            return arr;
        }
        public static void ArrayInfo(int[] arr) // ZAD3
        {

            int min = 0, max = 0;
            double average = 0;
            int positiveCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i]) min = arr[i];
                if (max < arr[i]) max = arr[i];
                if (arr[i] > 0) positiveCount++;
                average += arr[i];
            }

            int idxMin = Array.IndexOf(arr, min);
            int idxMax = Array.IndexOf(arr, max);
            average = average / arr.Length;

            Console.WriteLine($"Najmniejszy element: {min}, index: {idxMin}");
            Console.WriteLine($"Największy element: {max}, index: {idxMax}");
            Console.WriteLine($"Liczba dodatnich elementów wynosi: {positiveCount}");
            Console.WriteLine($"Średnia wartości wszystkich elementów wynosi: {average}");
        }

        public static bool IsPrime(int number) // ZAD4 f pomocnicza
        {
            if (number < 2) return false;
            if (number == 2) return true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;

            }

            return true;
        }

        public static void WritePrimes(int min, int max) // ZAD4
        {
            for (int i = min; i <= max; i++)
            {
                if (IsPrime(i)) Console.WriteLine(i);
            }

            Console.WriteLine("");
        }
    }
}

