using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

// Ищет самую длинную подстроку
namespace _11409_MaximChernykh.SubstringNamespace
{
    internal class Substring
    {
        public string SearchSubstring() 
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            string substring = "";
            List<int> nums = new List<int>();
            List<string> substrings = new List<string>();
            int count = 0;

            for(int i = 0;  i < str.Length; i++)
            {
                if (!substring.Contains(str[i]))
                {
                    substring += str[i];
                    count++;
                }
                else
                {
                    nums.Add(count);
                    count = 0;
                    substrings.Add(substring);
                    substring = "";
                }
            }

            Console.WriteLine("Самая длинная уникальная подстрока - " + substrings.Max() + ". Её длина - " + nums.Max());
            return substrings.Max();
        }
    }
}
