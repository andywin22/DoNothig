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

namespace DoNothig
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0, 0);
            Size = new Size(w, h);

            int lw = label5.Width / 2;
            int lh = label5.Height / 2 + 100;
            label5.Location = new Point(w / 2 - lw, h / 2 - lh);

            Tracker();

           
        }

        private void Tracker()
        {
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = 5;
            time--;
            if (time == 0) timer1.Dispose();
        }
    }
}
