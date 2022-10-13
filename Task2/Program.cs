using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.ToLower();
            str = str.Replace(" ", "");
            string p = "";
            foreach (char c in str)
            {
                p = c + p;
            }
            if (str == p)
            {
                Console.WriteLine("Введенное предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Введенное предложение не является палиндромом");
            } 
            Console.ReadKey();
        }
    }
}
