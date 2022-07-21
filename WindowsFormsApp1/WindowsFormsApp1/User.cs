using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        private string _username;//encapsulating
        private string _password;
        private string usertype;

        //constructor
        public User (string username,string pass)
        {
            _username = username;
            _password = pass;
        }
        public User(string u,string p, string type)
        {
            this._username = u;
            this._password = p;
            usertype = type;
        }
        // properties
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
           
            get { return _password;}
            set { _password = value; }
        }
        public String UserType
        {set { usertype = value; }
            get { return usertype; }
        }
        
     
        

        


        
        

        

    }
}
