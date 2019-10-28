using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chaos_game
{
    public partial class drawStartPoints : Component
    {
        public drawStartPoints()
        {
            InitializeComponent();
        }

        public drawStartPoints(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void drawPoints_Paint(object sender, PaintEventArgs events)
        {
            Font fnt = new Font("Arial", 16);
            Pen redBrush = new Pen(Color.Red);
            SolidBrush blackB = new SolidBrush(Color.Black);
            
            //DRAW START POINTS
            events.Graphics.DrawRectangle(redBrush, 388, startPanel.Height / 10, 2, 2); //A
            events.Graphics.DrawString("A", fnt, blackB, 378, startPanel.Height / 25);
            events.Graphics.DrawRectangle(redBrush, 188, 350, 2, 2); //B
            events.Graphics.DrawString("B", fnt, blackB, 179, 355);
            events.Graphics.DrawRectangle(redBrush, 588, 350, 2, 2); //C
            events.Graphics.DrawString("C", fnt, blackB, 578, 355);
            //

        }

    }
}
