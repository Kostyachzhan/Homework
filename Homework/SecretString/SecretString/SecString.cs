using System;
using System.Collections.Generic;
using System.Text;

namespace SecretString.Check
{
    class SecString
    {
        public string password = "12345";
        public string line;
        public string Line 
        {
            get { return line; }
            set { line = value; } 
        }

        public void CheckPass(string pass)
        {
            if (pass == password)
            {
                Console.WriteLine("Password correct your line: " + line);
                Console.WriteLine("What do you want Change Password or Secreat String(choose 1 or 2): ");
                string ch = Console.ReadLine();
                switch (ch) 
                {
                    case "1":
                        PasswordChange(pass);
                        break;
                    case "2":
                        StringChange(pass);
                        break;
                    default: Console.WriteLine("Wrong case!!!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Encorrect password!");
            }

        }

        public void PasswordChange(string pass) 
        {
            if (pass == password)
            {
                Console.WriteLine("New password");
                password = Console.ReadLine();
                Console.WriteLine("Your new password: " + password);
            }
            else 
            {
                Console.WriteLine("Encorrect password");
            }
        }

        public void StringChange(string pass) 
        {
            if (pass == password) 
            {
                Console.WriteLine("Write new string: ");
                Line = Console.ReadLine();
                Console.WriteLine("Your new Secret string: " + line);
                
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }
}
