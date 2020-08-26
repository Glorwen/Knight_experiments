using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knight
{
    public partial class Form1 : Form
    {

        int frameCounter = 1;
        string direction = "right";
        int knightStep = 7;
        int horizontalVelocity = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeKnight();
        }

        private void InitializeKnight()
        {
            Knight.BackColor = Color.Transparent;
            timer1.Interval = 200;
            timer1.Start();
            this.KeyDown += Form1_KeyDown;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string imageName = "knight_" + direction + "_" + frameCounter.ToString();
            Knight.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            Knight.SizeMode = PictureBoxSizeMode.StretchImage;
            frameCounter++;
            if (frameCounter > 2)
            {
                frameCounter = 1;
            }
            Knight.Left += horizontalVelocity;
        }

        private void Form1_KeyDown (object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    direction = "right";
                    horizontalVelocity = knightStep;
                    break;
               
                case Keys.Left:
                    direction = "left";
                    horizontalVelocity = -knightStep;
                    break;
                
            }
        }
    }

}
