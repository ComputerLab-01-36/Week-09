using System;
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle face = new Rectangle(162, 92,150,125);
            Rectangle eyeleft = new Rectangle(200, 130, 20, 20);
            Rectangle eyeright = new Rectangle(252, 130, 20, 20);
            Rectangle earleft = new Rectangle(162, 90, 40, 40);
            Rectangle earright = new Rectangle(272, 90, 40, 40);
            Rectangle mouth = new Rectangle(212, 160, 50, 40);
            Rectangle noseleft = new Rectangle(225, 170, 10, 10);
            Rectangle noseright = new Rectangle(240, 170, 10, 10);







            g.FillEllipse(Brushes.Pink, earleft);
            g.FillEllipse(Brushes.Pink, earright);

            g.FillEllipse(Brushes.Pink, face);
            g.FillEllipse(Brushes.Black, eyeleft);
            g.FillEllipse(Brushes.Black, eyeright);
            g.FillEllipse(Brushes.HotPink, mouth);
            g.FillEllipse(Brushes.Black, noseleft);
            g.FillEllipse(Brushes.Black, noseright);


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "x : " + e.X.ToString();
            label2.Text = "y : " + e.Y.ToString();

        }
    }
}
