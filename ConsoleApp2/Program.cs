using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1234567890";

            if (a.Contains ("345"))
            {
                Console.WriteLine("deu certo");
            }
            else
            {
                Console.WriteLine("deu errado");
            }
        }
    }
}
