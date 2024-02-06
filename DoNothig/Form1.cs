using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace DoNothig
{
    public partial class Menu : Form
    {
        public int w = Screen.PrimaryScreen.Bounds.Width;
        public int h = Screen.PrimaryScreen.Bounds.Height;
        public bool main = false;
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
            Size = new Size(w, h);

            int lw = label1.Width / 2;
            int lh = label1.Height / 2 + 100;
            label1.Location = new Point(w / 2 - lw, h / 2 - lh);

            int gw = label2.Width / 2;
            int gh = label2.Height / 2 - 15;
            label2.Location = new Point(w / 2 - gw, h / 2 - gh);
            label4.Location = new Point(w / 2 - gw, h / 2 - gh);

            int qw = label3.Width / 2;
            int qh = label3.Height / 2 - 100;
            label3.Location = new Point(w / 2 - qw, h / 2 - qh);
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkSalmon;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkSalmon;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gainsboro;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Gainsboro;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkSalmon;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Gainsboro;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Invoke((Action)(() =>
            {
                label1.Text = "Don't Move Your Mouse";
            }));
            label2.Visible = false;
            label3.Visible = false;

            Thread move = new Thread(Tracker);
            move.Start();
        }

        void Tracker()
        {
            int fx = MousePosition.X;
            int fy = MousePosition.Y;         
            bool check = true;
            while (check)
            {
                Thread.Sleep(5);
                int x = MousePosition.X;
                int y = MousePosition.Y;

                if (x != fx || y != fy)
                {
                    this.Invoke((Action)(() =>
                    {
                        label1.Text = "You Moved!!!";
                        check = false;
                        main = true;
                        label4.Visible = true;
                    }));
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label1.Text = "Do Nothing";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
        }
    }
}
