using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Logging : Form
    {
        public Logging()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(); 
            Authentication au = new Authentication();

            string user= txtUserName.Text;  
            string password= txtPassword.Text;
            if ((user == "") && (password == ""))
                MessageBox.Show("ENTER BOTH USERNAME AND PASSWORD");
            else if (au.authentication(user, password))
            {
                fm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("INVALID CREDENTIALS");
        }
    }
}
