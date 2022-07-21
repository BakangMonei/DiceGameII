using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    internal class Register
      
    {
        private User us;
        private student stud;
        private StreamWriter sw1, sw2;
        public Register(student st)
        {
            stud = st;
            
        }
        public void SaveStudentDetails()
        {
            string studentDetails = stud.FirstName + "#" + stud.SurName;
            string UserDetails = us.UserName + " " + us.Password + " " + us.UserType;
            sw1 = File.AppendText("UserDetails.txt");
            sw2 = File.AppendText("StudentDetails.txt");
            sw1.WriteLine();
            sw2.WriteLine();
            sw1.Close();
            sw2.Close();

        }
    }
}
