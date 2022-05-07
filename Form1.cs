using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Photoshop : Form
    {
        private int szer = 0 , wys = 0;
        Color k1, k2;
        public Photoshop()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k2 = b2.GetPixel(i, j);
                    b1.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.WaitCursor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color rgb;
            Color szary;
            int avg;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    rgb = b1.GetPixel(i, j);
                    avg = (rgb.R+rgb.G+rgb.B)/3;
                    szary = Color.FromArgb(avg, avg, avg);
                    b2.SetPixel(i,j,szary);
                }
                
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color c1;
           // Color c2;
            int prog = (int)numericUpDown1.Value;
            int avg;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    c1 = b1.GetPixel(i, j);
                    avg = avg = (c1.R + c1.G + c1.B) / 3;
                    if(avg < prog)
                    {
                        b2.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        b2.SetPixel(i, j, Color.White);
                    }
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color c1;
            Color c2;
            Color[,] pixelColor;

            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                     c1 = b1.GetPixel(i, j);

                }
            }
        }

        private void odczytaj_Click(object sender, EventArgs e)
        {
            if (odczyt.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Load(odczyt.FileName);
                szer=pictureBox3.Image.Width;
                wys=pictureBox3.Image.Height;
                pictureBox2.Load(odczyt.FileName);
                pictureBox2.Image = new Bitmap(szer,wys);
              
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap b1 =(Bitmap)pictureBox3.Image;
            Bitmap b2 =(Bitmap)pictureBox2.Image;
            for(int i = 0; i < szer; i++)
            {
                for(int j = 0; j < wys; j++)
                {
                    k1 = b1.GetPixel(i, j);
                    k2 = Color.FromArgb(k1.B,k1.G, k1.R);
                    b2.SetPixel(i, j, k2);
                }
                
            }
            pictureBox2.Refresh();
            Cursor = Cursors.WaitCursor;    
        }
    }
}
