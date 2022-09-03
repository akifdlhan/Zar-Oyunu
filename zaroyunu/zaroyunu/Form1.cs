using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaroyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast=new Random();
        int toplamplayer = 0;
        int toplampc=0;
        int vurus1 = 0;
        int vurus2 = 0;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            
            int a=rast.Next(1,7);
            int b=rast.Next(1,7);
            label2.Text = a.ToString();
            label3.Text = b.ToString();
            toplamplayer += a + b;
            label1.Text = toplamplayer.ToString();
            if (a == 1)
            {
                pictureBox1.ImageLocation= "C:\\Users\\MONSTER\\Desktop\\1.jpg";
            }else if(a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\2.jpg";
            }else if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\3.jpg";
            }else if(a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\4.jpg";
            }else if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\5.jpg";
            }else if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\6.jpg";
            }
            if(b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\1.jpg";
            }else if(b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\2.jpg";
            }else if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\3.jpg";
            }else if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\4.jpg";
            }else if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\5.jpg";
            }else if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\6.jpg";
            }
            vurus1++;
            if (vurus1 == 10)
            {
                btn_Start.Enabled = false;
                
            }            
        }
        private void btn_start2_Click(object sender, EventArgs e)
        { 
            vurus2++;
            int c = rast.Next(1,7);
            int d=rast.Next(1,7); 
            label7.Text=c.ToString();
            label6.Text=d.ToString();
            toplampc+=d+c;
            label4.Text=toplampc.ToString();          
            if (vurus2 == 10)
            {
                btn_start2.Enabled = false;
                if (Convert.ToInt32(label1.Text) < Convert.ToInt32(label4.Text))
                {
                    MessageBox.Show("COMPUTER KAZANDIIIIII");

                }
                else
                {
                    MessageBox.Show("PLAYER KAZANDIIIIIII");
                }
            }

        }
    }
}
