using System;

namespace Secret_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter secret string: ");
            string line = Console.ReadLine();
            SecString str = new SecString(password, line);
            Console.WriteLine(str.ReturnString(password));
            string new_password = Console.ReadLine();
            string new_line = Console.ReadLine();

            str.PasswordChange(password, new_password);
            Console.WriteLine(str.ReturnString(password));
            Console.WriteLine(str.ReturnString(new_password));
            str.StringChange(new_password, new_line);
            Console.WriteLine(str.ReturnString(new_password));

            Console.ReadKey();
        }

    }
}
