using System;
using System.Drawing;
using System.Windows.Forms;
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

            int lw = Title.Width / 2;
            int lh = Title.Height / 2 + 100;
            Title.Location = new Point(w / 2 - lw, h / 2 - lh);

            int gw = btnStart.Width / 2;
            int gh = btnStart.Height / 2 - 15;
            btnStart.Location = new Point(w / 2 - gw, h / 2 - gh);
            btnMenu.Location = new Point(w / 2 - gw, h / 2 - gh);

            int qw = btnQuit.Width / 2;
            int qh = btnQuit.Height / 2 - 100;
            btnQuit.Location = new Point(w / 2 - qw, h / 2 - qh);

            TimeRec();
        }
        private void TimeRec()
        {
            int timerec = Properties.Settings.Default.TimeRec;
            string hour = ((timerec / 3600).ToString().Length == 1) ? "0" + (timerec / 3600).ToString() : (timerec / 3600).ToString();
            string minute = (((timerec % 3600) / 60).ToString().Length == 1) ? "0" + ((timerec % 3600) / 60).ToString() : ((timerec % 3600) / 60).ToString();
            string second = ((((timerec % 3600) % 60).ToString()).Length == 1) ? "0" + ((timerec % 3600) % 60).ToString() : ((timerec % 3600) % 60).ToString();
            timeCount.Text = hour + ":" + minute + ":" + second;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            button.ForeColor = Color.DarkSalmon;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            button.ForeColor = Color.Gainsboro;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Invoke((Action)(() =>
            {
                Title.Text = "Don't Move Your Mouse";
                time = 0;
                record.Visible = false;
                timeCount.Location = new Point(0, 2);
            }));

            btnStart.Visible = false;
            btnQuit.Visible = false;

            Thread move = new Thread(Tracker);
            move.Start();
            timer1.Start();
        }

        void Tracker()
        {
            int fx = MousePosition.X;
            int fy = MousePosition.Y;
            int randomEvent = 0;
            bool check = true;

            while (check)
            {
                Thread.Sleep(5);
                int x = MousePosition.X;
                int y = MousePosition.Y;
                randomEvent++;
                if (x != fx || y != fy)
                {
                    this.Invoke((Action)(() =>
                    {
                        Title.Text = "You Moved!!!";
                        check = false;
                        main = true;
                        btnMenu.Visible = true;
                    }));
                    if (main)
                    {
                        timer1.Stop();

                        int timerec = Properties.Settings.Default.TimeRec;  //checking if time now longer than record
                        Properties.Settings.Default.TimeRec = (timerec > time) ? time : timerec;
                        Properties.Settings.Default.Save();

                        break;
                    }
                }
                /*    if (randomEvent == 2000)
                    {
                        Random rdm = new Random();
                        int rdmNum = rdm.Next();
                        if (rdmNum % 9 == 1)
                        {
                            notifyIcon1.ShowBalloonTip(5000, "Notification", "You got a message", ToolTipIcon.Info);
                        }
                        if (rdmNum % 9 == 2)
                        {
                            this.Invoke((Action)(() =>
                            {
                                label1.Text = "You Moved ?";
                            }));
                        }
                        randomEvent = 0;
                    }
                */
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Title.Text = "Do Nothig";

            record.Visible = true;
            timeCount.Location = new Point(103, 2);

            TimeRec();

            btnStart.Visible = true;
            btnQuit.Visible = true;
            btnMenu.Visible = false;
        }

        private void Menu_SizeChanged(object sender, EventArgs e)
        {
            w = this.ClientSize.Width;
            h = this.ClientSize.Height;

            int lw = Title.Width / 2;
            int lh = Title.Height / 2 + 100;
            Title.Location = new Point(w / 2 - lw, h / 2 - lh);

            int gw = btnStart.Width / 2;
            int gh = btnStart.Height / 2 - 15;
            btnStart.Location = new Point(w / 2 - gw, h / 2 - gh);
            btnMenu.Location = new Point(w / 2 - gw, h / 2 - gh);

            int qw = btnQuit.Width / 2;
            int qh = btnQuit.Height / 2 - 100;
            btnQuit.Location = new Point(w / 2 - qw, h / 2 - qh);
        }

        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            string hour = ((time / 3600).ToString().Length == 1) ? "0" + (time / 3600).ToString() : (time / 3600).ToString();
            string minute = (((time % 3600) / 60).ToString().Length == 1) ? "0" + ((time % 3600) / 60).ToString() : ((time % 3600) / 60).ToString();
            string second = ((((time % 3600) % 60).ToString()).Length == 1) ? "0" + ((time % 3600) % 60).ToString() : ((time % 3600) % 60).ToString();
            timeCount.Text = hour + ":" + minute + ":" + second;
        }
    }
}
