using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Dice
    {

        public Image getDice(int numbers)
        {
            Image[] images = new Image[6];
            
            images[0] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Normal\\dice1.jpeg");
            images[1] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Normal\\dice2.jpeg");
            images[2] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Normal\\Dice3.jpeg");
            images[3] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Normal\\dice4.jpeg");
            images[4] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Normal\\dice5.jpeg");
            images[5] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Normal\\dice6.jpeg"); 
            
            return images[numbers];

            
            

        }
        public Image[] getRotated()
        {
            Image[] rots = new Image[4];
            rots[0] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Rotated dice\\rot00.jpg");
            rots[1] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Rotated dice\\rot01.jpg");
            rots[2] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Rotated dice\\rot02.jpg");
            rots[3] = Image.FromFile("C:\Users\cse20-018\Desktop\dicegame\WindowsFormsApp1\WindowsFormsApp1\Rotated dice\\rot03.jpg");
           

            return rots;
            
        }

    }
}
