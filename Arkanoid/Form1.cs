using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arkanoid.Classes;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {            
            Graphics g = Graphics.FromHwnd(PlayPnl.Handle);
            g.FillRectangle(SystemBrushes.Window, new Rectangle(0, 0, PlayPnl.Width, PlayPnl.Height));
            foreach (Item item in Render.items)
            {
                if (item is Ball)
                    g.FillEllipse(Brushes.Black, new RectangleF(item.CornerLocation, item.Size));
                else
                    g.FillRectangle(Brushes.Black, new RectangleF(item.CornerLocation, item.Size));
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {             
                case Keys.A:
                    GameControl.SetLeft();
                    break;
                case Keys.D:
                    GameControl.SetRight();
                    break;
                case Keys.Space:
                    if (timer.Enabled)
                        timer.Stop();
                    else
                        timer.Start();
                    break;                    
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    GameControl.KeyUpLeft();
                    break;
                case Keys.D:
                    GameControl.KeyUpRight();
                    break;

            }
            
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            game = new Game();
            PlayBtn.Visible = false;
            PlayBtn.Enabled = false;
            Focus();
            Invalidate();
            game.Start();
            timer.Start();
            Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (game != null)
            {
                game.Play();
                Invalidate();
            }
        }
    }
}
