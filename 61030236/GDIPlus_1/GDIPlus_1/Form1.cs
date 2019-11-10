﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace GDIPlus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen bluepen = new Pen(Color.Blue, 2);
            g.DrawRectangle(bluepen, 10, 10, 100, 100);
            bluepen.Dispose();

            Pen SomePen = new Pen(Color.FromArgb(255, 120, 200));
            g.DrawEllipse(SomePen, 20, 20, 200, 200);
            SomePen.Dispose();

            Color col = Color.FromName("LightGreen");
            this.BackColor = col;


        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen bluepen = new Pen(Color.Blue, 2);
            g.DrawRectangle(bluepen, 10, 10, 100, 100);
            bluepen.Dispose();

            Pen SomePen = new Pen(Color.FromArgb(255, 120, 200));
            g.DrawEllipse(SomePen, 20, 20, 200, 200);
            SomePen.Dispose();

            Color col = Color.FromName("LightGreen");
            this.BackColor = col;
        }
    }
}
