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
        {
            this.Text = "Chaos Game";
        }

        private void panel1_Paint(object sender, PaintEventArgs events)
        {
            drawStartPoints drawStartP = new drawStartPoints();
            drawStartP.drawPoints_Paint(sender, events);
            mainGamePainting mainPaintObj = new mainGamePainting();
            mainPaintObj.mainPanel_Paint(sender,events);
        }
    }
}
