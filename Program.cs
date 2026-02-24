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
            string result = "";
            for (int i = 0; i < strNumbers.Count; i++)
            {
                result += strNumbers[i];
            }
            Console.WriteLine();
            Console.WriteLine("Наибольшее число: " + result);
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
