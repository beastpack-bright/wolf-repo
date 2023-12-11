using System;
using System.Drawing;
using System.Windows.Forms;

namespace BadForm
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            InitializeMouseFollowerPictureBox();
            penguinMove.MouseMove += Form2_MouseMove;
        }

        private void InitializeMouseFollowerPictureBox()
        {
            
            MouseMove += Form2_MouseMove;
            penguinMove.BringToFront();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            // Move the penguinMove PictureBox 
            penguinMove.Location = new Point(e.X - penguinMove.Width / 2, e.Y - penguinMove.Height / 2);
        }

    }
}
