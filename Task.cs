using System;
using System.Collections.Generic;

namespace Kolokwium2
{
    enum Consoles // ZAD9 enum pomocniczy
    {
        Nes = 1,
        Snes = 2,
        N64,
        NGC,
        NWii,
        NSwitch
    }
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

        public static void DisplayMatrixes(int n, int m) // ZAD5
        {
            int[,] a = new int[n, m];
            int[,] b = new int[n, m];
            int[,] c = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(100);
                    b[i, j] = rnd.Next(100);
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            for (int matrixIndex = 0; matrixIndex < 3; matrixIndex++)
            {
                if (matrixIndex == 0) Console.WriteLine("Macierz A:");
                if (matrixIndex == 1) Console.WriteLine("Macierz B:");
                if (matrixIndex == 2) Console.WriteLine("Macierz C:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrixIndex == 0) Console.Write($"{a[i, j]}\t");
                        if (matrixIndex == 1) Console.Write($"{b[i, j]}\t");
                        if (matrixIndex == 2) Console.Write($"{c[i, j]}\t");

                    }

                    Console.WriteLine();
                }
            }
        }
        static int GetCharId(char input, List<char> charList)
        {
            for (int i = 0; i < charList.Count; i++)
            {
                if (input == charList[i]) { return i; }
            }
            return -1;
        }
        static bool IsOnList(char input, List<char> list)// ZAD6 f pomocnicza
        {
            foreach (char item in list)
            {
                if (input == item) return true;
            }
            return false;
        }
        static void DisplayCharCounter(List<char> charList, List<int> intList) // ZAD6 f pomocnicza
        {
            int iterator = 0;
            foreach (char item in charList)
            {
                Console.Write($" {item} - {intList[iterator]},");
                iterator += 1;
            }
        }
        public static void CharCounter(string input) // ZAD6
        {
            List<char> charList = new();
            List<int> intList = new();
            for (int i = 0; i < input.Length; i++)
            {
                if (IsOnList(input[i], charList))
                { intList[GetCharId(input[i], charList)] += 1; }
                else
                { charList.Add(input[i]); intList.Add(1); }
            }
            DisplayCharCounter(charList, intList);
        }

        public static void CountUsageYears() // ZAD7
        {
            string[] items = { "NES-1983", "SNES-1991", "N64-1996", "NGC-2001", "NWII-2006" };
            for (int i = 0; i < items.Length; i++)
            {
                string[] yearBought = items[i].Split('-');
                Console.WriteLine($"Dla produktu: {yearBought[0]}");
                int intYearBought = DateTime.Now.Year - Convert.ToDateTime($"1/1/{yearBought[1]}").Year;
                string usageYears = (intYearBought < 0) ? $"upłyneły {intYearBought} lata" : $"uplyneło {intYearBought} lat";
                Console.WriteLine($"Od daty zakupu {usageYears}");
            }
        }
        public static void Encryption(string input) // ZAD8
        {
            string code = "GADERYPOLUKI";
            string output = String.Empty;
            input = input.ToUpper();
            for (int a = 0; a < input.Length; a++)
            {
                for (int b = 0; b < code.Length; b++)
                {
                    if (input[a] == code[b])
                    {
                        if (b % 2 == 0) { output += code[b + 1]; }
                        else { output += code[b - 1]; }
                    }
                }
                if (output.Length - a == 0) { output += input[a]; }
            }
            Console.WriteLine(output);
        }

        public static void EnumInfo() // ZAD9
        {
            int namesCount = Enum.GetNames(typeof(Consoles)).Length;
            for (int i = 0; i < namesCount; i++)
            {
                Console.WriteLine($"Enum:{Enum.GetNames(typeof(Consoles))[i]} Wartość: {i}");
            }
        }

        public static void DisplayDate() //ZAD10
        {
            DateTime date = new DateTime(2016, 05, 14, 5, 30, 0);

            DateTime a = date;
            DateTime b = DateTime.Now;

            Console.WriteLine(date.ToString("dddd"));
            Console.WriteLine(date.ToString("MMMM"));
            Console.WriteLine($"Różnica: {b.Year - a.Year} lat");
        }
    }
}

