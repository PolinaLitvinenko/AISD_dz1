using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD_dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание");
            Console.WriteLine("Введите количество массивов");
            int k = IntInput();
            int[][] arr = new int[k][];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Введите числа через пробел в отсортированном порядке");
                string s1 = StrInput();
                string[] numbers = s1.Split(' ');
                arr[i] = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    arr[i][j] = int.Parse(numbers[j]);
                }
            }

            int[] p = new int[arr.Length];
            List<int> result = new List<int>();
            while (true)
            {
                int minValue = int.MaxValue;
                int minArrayIndex = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (p[i] < arr[i].Length)
                    {
                        int currentValue = arr[i][p[i]];
                        if (currentValue < minValue)
                        {
                            minValue = currentValue;
                            minArrayIndex = i;
                        }
                    }
                }
                if (minArrayIndex == -1)
                    break;
                result.Add(minValue);
                p[minArrayIndex]++;
            }
            Console.WriteLine(string.Join(" ", result));
            Console.WriteLine("2 задание");
            Console.Write("Введи числа через пробел");
            Console.WriteLine();
            string s = StrInput();
            string[] num = s.Split(' ');
            List<string> strNumbers = new List<string>();
            for (int i = 0; i < num.Length; i++)
            {
                strNumbers.Add(num[i]);
            }
            for (int i = 0; i < strNumbers.Count - 1; i++)
            {
                for (int j = i + 1; j < strNumbers.Count; j++)
                {
                    string a = strNumbers[i];
                    string b = strNumbers[j];
                    string ab = a + b;
                    string ba = b + a;
                    if (string.Compare(ba, ab) > 0)
                    {
                        strNumbers[i] = b;
                        strNumbers[j] = a;
                    }
                }
            }
            if (strNumbers[0] == "0")
            {
                Console.WriteLine();
                Console.WriteLine("Наибольшее число: 0");
                return;
            }
            string result2 = "";
            for (int i = 0; i < strNumbers.Count; i++)
            {
                result2 += strNumbers[i];
            }
            Console.WriteLine();
            Console.WriteLine("Наибольшее число: " + result2);

        }


        static int IntInput()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int IntNum))
                {
                    return IntNum;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный формат, введите число");
                }

            }
        }
        static string StrInput()
        {
            while (true)
            {
                string str = Console.ReadLine().Trim();
                if (str.Length > 0)
                {
                    return str;
                }
                else
                {
                    Console.WriteLine("Введен неверный формат, введите строку");
                }
            }
        }
    }
}
