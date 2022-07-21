using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class student
    {
        private string username;
        private string password;
        private string userType;
        private string firstname;
        private string surname;

        //constructor
        public student(string username, string pass)
        {
            this.username = username;
            this.password = pass;

        }
        public student(string u, string p, string type)
        {
            this.username = u;
            this.password = p;
            this.userType = type;
        }
        //Properties
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string PassWord
        { set { password = value; }
            get { return password; }
        }

        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        public string FirstName
        {
            set { firstname = value; }
            get { return firstname;}
        }
        public string SurName
        {
            set { surname = value; }
            get { return surname;}
        }
            

        

            



    }
}
