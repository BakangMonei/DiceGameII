using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Authentication
    {
        public bool authentication(string username,string password) 
        {
            string[] users = { "Bofelo","Rose","Gofa" ,"Lala","Gape" };
            string[] pass =  { "7648","7799","2512","3024","0013" };

            int size = users.Length;
            for (int i = 0; i < size; i++) 
            {
                if(username == users[i] && password== pass[i] )
                    return true;
            }
            return false;
        }
             

    }
}
