using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_String
{
    class SecString
    {
        private string password;
        private string line;


        public SecString(string password, string line)
        {
            this.password = password;
            this.line = line;
        }

        public void PasswordChange(string pass, string new_pass)
        {
            if (pass == password)
            {
                password = new_pass;
            }
            else
            {

                throw new Exception("Incorrect password");
            }

        }
        public void StringChange(string pass, string new_string)
        {
            if (pass == password)
            {
                line = new_string;
            }
            else
            {
                throw new Exception("Incorrect password");
            }
        }

        public string ReturnString(string pass)
        {
            if (pass == password)
            {
                return line;
            }
            else
            {
                return null;
            }
        }
    }
}

