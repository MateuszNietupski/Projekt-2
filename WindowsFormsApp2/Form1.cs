using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Web.UI.DataVisualization.Charting;

namespace WindowsFormsApp2
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
            int _b = 127;
            Color c1;
            int r, g, b;

            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    c1 = b1.GetPixel(i, j);

                    r = c1.R + _b;
                    g = c1.G + _b;
                    b = c1.B + _b;

                    if (c1.R + _b > 255)
                    {
                        r = 255;
                    }
                    if (c1.G + _b > 255)
                    {
                        g = 255;
                    }
                    if (c1.B + _b > 255)
                    {
                        b = 255;
                    }

                      b2.SetPixel(i, j, Color.FromArgb(r, g, b));

                }
            }
            pictureBox2.Refresh();
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
            int _b = 127;
            Color k;
            int r, g, b;

            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k = b1.GetPixel(i, j);

                    r = k.R - _b;
                    g = k.G - _b;
                    b = k.B - _b;

                    if (k.R - _b < 0)
                    {
                        r = 0;
                    }
                    if (k.G - _b < 0)
                    {
                        g = 0;
                    }
                    if (k.B - _b < 0)
                    {
                        b = 0;
                    }

                      b2.SetPixel(i, j, Color.FromArgb(r, g, b));

                }
            }
            pictureBox2.Refresh();
        }

        private void Koniec_Click(object sender, EventArgs e)
        {
            if (odczyt.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Load(odczyt.FileName);
                         
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color c1,c2;
            
            int r=0,g=0,b=0;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    c1 = b1.GetPixel(i, j);
                    c2 = b2.GetPixel(i, j);
                    
                    if ((c1.R + c2.R) == 255) r = 255;
                    else r = (c1.R + c2.R) % 255;
                    if ((c1.G + c2.G) == 255) g = 255;
                    else g = (c1.G + c2.G) % 255;
                    if ( (c1.B + c2.B) == 255) b = 255;
                    else b = (c1.B + c2.B) % 255;
                    
                    b2.SetPixel(i,j,Color.FromArgb(r,g,b));
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color c1, c2;

            int r = 0, g = 0, b = 0;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    c1 = b1.GetPixel(i, j);
                    c2 = b2.GetPixel(i, j);
                    if (c1.R + c2.R - 255 < 0) r = 0;
                    else r = c1.R + c2.R - 255;
                    if (c1.G + c2.G - 255 < 0) g = 0;
                    else g = c1.G + c2.G - 255;
                    if (c1.B + c2.B - 255 < 0) b = 0;
                    else b = c1.B + c2.B - 255;
                    b2.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color c1, c2;

            int r = 0, g = 0, b = 0;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    c1 = b1.GetPixel(i, j);
                    r = 255 - c1.R;
                    g = 255 - c1.G;
                    b = 255 - c1.B;
                    b2.SetPixel(i,j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color c1, c2;

            int r = 0, g = 0, b = 0;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    c1 = b1.GetPixel(i, j);
                    c2 = b2.GetPixel(i, j);
                    if (c1.R - c2.R < 0) r = (c1.R - c2.R) * (-1);
                    else r = c1.R - c2.R;
                    if (c1.G - c2.G < 0) g = (c1.G - c2.G) * (-1);
                    else g = c1.G - c2.G;
                    if (c1.B - c2.B < 0) b = (c1.B - c2.B) * (-1);
                    else b = c1.B - c2.B;
                    b2.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color c1, c2;

            int r = 0, g = 0, b = 0;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    c1 = b1.GetPixel(i, j);
                    c2 = b2.GetPixel(i, j);
                    if (c1.R * c2.R > 255) r = (c1.R * c2.R) % 255;
                    else r = c1.R * c2.R;
                    if (c1.G * c2.G > 255) g = (c1.G * c2.G) % 255;
                    else g = c1.G * c2.G;
                    if (c1.B * c2.B > 255) b = (c1.B * c2.B) % 255;
                    else b = c1.B * c2.B;
                    b2.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox3.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color k;
            int r, g, b;
            byte[] tab = new byte[256];
            double a = 127;

            for (int i = 0; i < 256; i++)
            {
                if ((a * (i - 127) + 127) > 255)
                {
                    tab[i] = 255;
                }
                else if ((a * (i - 127) + 127) < 0)
                {
                    tab[i] = 0;
                }
                else
                {
                    tab[i] = (byte)(a * (i - 127) + 127);
                }
            }

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k = b1.GetPixel(x, y);
                    r = k.R;
                    g = k.G;
                    b = k.B;

                    r = tab[r];
                    g = tab[g];
                    b = tab[b];

                    b2.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            }
            
        

        private void odczytaj_Click(object sender, EventArgs e)
        {
            if (odczyt.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Load(odczyt.FileName);
                szer=pictureBox3.Image.Width;
                wys=pictureBox3.Image.Height;
                pictureBox2.Load(odczyt.FileName);
              //  pictureBox2.Image = new Bitmap(szer,wys);
              
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
