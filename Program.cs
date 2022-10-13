using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            int k = strArray[0].Length;
            int m = 0;
            for (int i = 1; i < strArray.Length; i++)
            {
                
                if (strArray[i].Length > k)
                {
                    k = strArray[i].Length;
                    m = i;
                }
            }
            Console.WriteLine("Самое длинное слов состоит из " + k + " букв");
            Console.WriteLine("Это слово - " + strArray[m]);
            Console.ReadKey();
        }
    }
}
