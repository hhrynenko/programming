using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chaos_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            Font fnt = new Font("Arial",16);
            Pen redBrush = new Pen(Color.Red);
            SolidBrush blackB = new SolidBrush(Color.Black);
            Random rand = new Random();

            //DRAW START POINTS
            e.Graphics.DrawRectangle(redBrush, 388, panel1.Height/10 , 2, 2); //A
            e.Graphics.DrawString("A", fnt, blackB, 378,panel1.Height/25);
            e.Graphics.DrawRectangle(redBrush, 188, 350, 2, 2); //B
            e.Graphics.DrawString("B", fnt, blackB, 179, 355);
            e.Graphics.DrawRectangle(redBrush, 588, 350, 2, 2); //C
            e.Graphics.DrawString("C", fnt, blackB, 578, 355);
            //

            for (int i = 0; i < 100; i+=5)
            {
                    label1.Text = rand.Next(1, 6).ToString();
                    //e.Graphics.DrawRectangle(redBrush, 10 + i, 10 + i, 1, 1);
                    //Task.Delay(100).Wait();
            }
        }
    }
}
