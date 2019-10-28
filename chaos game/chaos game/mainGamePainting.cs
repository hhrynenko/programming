using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace chaos_game
{
    public partial class mainGamePainting : Component
    {
        public mainGamePainting()
        {
            InitializeComponent();
        }

        public mainGamePainting(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void mainPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs events)
        {
            int randomNumber = 0;
            int currentPointX = 388;
            int currentPointY = 40;
            Random randNumb = new Random();
            Pen blueBrush = new Pen(Color.Blue);
            drawStartPoints obj = new drawStartPoints();
            events.Graphics.DrawRectangle(blueBrush, currentPointX, currentPointY, 0, 0);
            for(int iteration = 0;iteration<10000;iteration++)
            {
                randomNumber = randNumb.Next(1, 7);
                if(randomNumber == 6 || randomNumber == 5) // A
                {
                    currentPointX = (currentPointX + 388) / 2;
                    currentPointY = (currentPointY + 20) / 2;
                    events.Graphics.DrawRectangle(blueBrush, currentPointX, currentPointY, 1, 1);
                    Task.Delay(500);
                }
                else if(randomNumber == 4 || randomNumber == 3) // B
                {
                    currentPointX = (currentPointX + 188) / 2;
                    currentPointY = (currentPointY + 350) / 2;
                    events.Graphics.DrawRectangle(blueBrush, currentPointX, currentPointY, 1, 1);
                    Task.Delay(500);
                }
                else if (randomNumber == 2 || randomNumber == 1) // C
                {
                    currentPointX = (currentPointX + 588) / 2;
                    currentPointY = (currentPointY + 350) / 2;
                    events.Graphics.DrawRectangle(blueBrush, currentPointX, currentPointY, 1, 1);
                    Task.Delay(500);
                }

            }
        }
    }
}
