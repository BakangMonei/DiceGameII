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
    public partial class Form1 : Form
    {Random rand = new Random();
        Dice dc = new Dice();
        Image[] Rotated = new Dice().getRotated();
        int index=0;
        int w=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 20;
            pictureBox1.Image = Rotated[index];
            index++;
            if(index >3)
                index = 0;
            if (pictureBox1.Left >= 680)
            {
                w = rand.Next(0, 6);
                pictureBox1.Image = dc.getDice(w);
                timer1.Enabled = false;
            }


  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 20;
            timer1.Enabled = true;
            pictureBox2.Left = 20;
            timer2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Left = 20;
            pictureBox2.Left = 20;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left += 20;
            pictureBox2.Image = Rotated[index];
            index++;
            if(index>3)
                index= 0;
            if(pictureBox2.Left >= 680)
            {
                w= rand.Next(0, 6);
                pictureBox2.Image= dc.getDice(w);
                timer2.Enabled=false;
            }



        }
    }
}
