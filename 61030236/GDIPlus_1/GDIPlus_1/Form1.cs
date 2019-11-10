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
        private Brush brush;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image image = Image.FromFile("d:Capture.PNG");
            // Change "\\d:Capture.PNG" to match your image path and name.
            TextureBrush bruch = new TextureBrush(image);
            Rectangle rect = new Rectangle(10, 10, 180, 150);
            g.FillEllipse(brush, rect);
            g.Dispose();

        }
    }
}
