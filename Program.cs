using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD_dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество массивов");
            int k = IntInput();
            int[][] arr = new int[k][];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Введите числа через пробел в отсортированном порядке");
                string s = StrInput();
                string[] numbers = s.Split(' ');
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
}
