using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lopic_Click(object sender, EventArgs e)
        {
            openFileDiaPict.ShowDialog();
            picBox1.Load(openFileDiaPict.FileName);
        }

        private void bacolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void rotbut_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(picBox1.Image);
            bitmap.RotateFlip(RotateFlipType.Rotate270FlipXY);
            picBox1.Image = bitmap;
        }

        private void picolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            picBox1.BackColor = colorDialog1.Color;
        }

        private void picsize_Click(object sender, EventArgs e)
        {
            this.Width +=100;
            this.Height+=100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width -= 100;
            this.Height -= 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void chBk_CheckedChanged(object sender, EventArgs e)
        {
            if (chBk.Checked == true)
            {
                picBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                chBk.Checked = false;
                picBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
