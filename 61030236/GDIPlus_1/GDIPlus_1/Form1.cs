﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap("D:\\1.JPG");
            Rectangle destrect = new Rectangle(10, 10, bmp.Width / 2, bmp.Height / 2);
            Rectangle srcrect = new Rectangle(0, 0, bmp.Width + 20, destrect.Height);
            this.SetClientSizeCore(destrect.Width + 20, destrect.Height + 20);
            g.DrawImage(bmp, destrect, srcrect, GraphicsUnit.Pixel);
            g.Dispose();
        }
    }
}
