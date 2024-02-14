namespace DoNothig
{
    partial class Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Title = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.record = new System.Windows.Forms.Label();
            this.timeCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Microsoft New Tai Lue", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gainsboro;
            this.Title.Location = new System.Drawing.Point(8, 310);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1244, 130);
            this.Title.TabIndex = 0;
            this.Title.Text = "Do Nothig";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStart.Location = new System.Drawing.Point(789, 530);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(329, 79);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Game Start";
            this.btnStart.Click += new System.EventHandler(this.label2_Click);
            this.btnStart.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.btnStart.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.AutoSize = true;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.LightGray;
            this.btnQuit.Location = new System.Drawing.Point(789, 660);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(319, 79);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.Click += new System.EventHandler(this.label3_Click);
            this.btnQuit.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.btnQuit.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.AutoSize = true;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu.Location = new System.Drawing.Point(277, 620);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(337, 79);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.label4_Click);
            this.btnMenu.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.btnMenu.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.BackColor = System.Drawing.Color.Transparent;
            this.record.Font = new System.Drawing.Font("Microsoft New Tai Lue", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.ForeColor = System.Drawing.Color.LightGray;
            this.record.Location = new System.Drawing.Point(0, 0);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(136, 44);
            this.record.TabIndex = 4;
            this.record.Text = "Record :";
            // 
            // timeCount
            // 
            this.timeCount.AutoSize = true;
            this.timeCount.BackColor = System.Drawing.Color.Transparent;
            this.timeCount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCount.ForeColor = System.Drawing.Color.LightGray;
            this.timeCount.Location = new System.Drawing.Point(135, 2);
            this.timeCount.Name = "timeCount";
            this.timeCount.Size = new System.Drawing.Size(141, 44);
            this.timeCount.TabIndex = 5;
            this.timeCount.Text = "00:00:00";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1252, 953);
            this.Controls.Add(this.timeCount);
            this.Controls.Add(this.record);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1270, 1000);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Do Nothig";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.SizeChanged += new System.EventHandler(this.Menu_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label btnStart;
        private System.Windows.Forms.Label btnQuit;
        private System.Windows.Forms.Label btnMenu;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label record;
        private System.Windows.Forms.Label timeCount;
    }
}

