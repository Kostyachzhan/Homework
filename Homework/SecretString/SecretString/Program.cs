using System;
using SecretString.Check;

namespace SecretString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SecString str = new SecString();
            Console.WriteLine("Enter secret string: ");
            str.Line = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            
            str.CheckPass(password);

            Console.ReadKey();
        }
    }
}
