using System;
using System.Drawing;
using System.Windows.Forms;
using Гонка_чемпионов.Properties;

namespace Гонка_чемпионов
{
    public partial class Achievements : Form
    {
        #region Variables
        bool Maximized = (bool)Settings.Default["Maximized"];
        Size NormalSize = (Size)Settings.Default["NormalSize"];

        int StartsCount = (int)Settings.Default["StartsCount"];
        bool ach2 = (bool)Settings.Default["ach2"];
        bool ach3 = (bool)Settings.Default["ach3"];
        int TanksCount = (int)Settings.Default["TanksCount"];
        int PassenegerCarsCount = (int)Settings.Default["PassenegerCarsCount"];
        int RacingCarsCount = (int)Settings.Default["RacingCarsCount"];
        int CarsCount = (int)Settings.Default["CarsCount"];
        int AllMoney = (int)Settings.Default["AllMoney"];
        #endregion

        public Achievements()
        {
            InitializeComponent();

            #region Achievement verification
            if (StartsCount >= 20)
                AchivementActivation(0);

            if (ach2)
                AchivementActivation(1);

            if (ach3)
                AchivementActivation(2);

            if (TanksCount > 0)
                AchivementActivation(3);

            if (PassenegerCarsCount > 1)
                AchivementActivation(4);

            if (RacingCarsCount > 0)
                AchivementActivation(5);

            if (CarsCount == 4)
                AchivementActivation(6);

            if (AllMoney >= 100000)
                AchivementActivation(7);

            carsCountLabel.Text = $"{CarsCount} / 4";
            moneyCountLabel.Text = $"{AllMoney} / 100000";
            gamesCountLabel.Text = $"{StartsCount} / 20";
            progressBar1.Value = CarsCount;

            if (AllMoney > 100000)
                progressBar2.Value = 100000;
            else
                progressBar2.Value = AllMoney;

            if (StartsCount > 20)
                progressBar3.Value = 20;
            else
                progressBar3.Value = StartsCount;
            #endregion
        }

        #region Auxiliary methods
        public void AchivementActivation(int achsNumber)
        {
            System.Windows.Forms.Label[] labels = new System.Windows.Forms.Label[] { label1, label2, label3, label4, label5, label6, label7, label8 };
            PictureBox[] pictures = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            labels[achsNumber].Enabled = true;
            pictures[achsNumber].Visible = true;
        }

        public void Zeroing()
        {
            Settings.Default["Maximized"] = false;
            Settings.Default["FirstGameOpening"] = 0;

            Settings.Default.Save();
        }
        #endregion

        #region Technical buttons
        private void menuButton_Click(object sender, EventArgs e)
        {
            Settings.Default["Maximized"] = Maximized;
            Menu menu = new Menu();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = Location;
            menu.Size = Size;
            menu.Show();
            Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Zeroing();
            Application.Exit();
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            if (Maximized)
            {
                Maximized = false;
                this.StartPosition = FormStartPosition.Manual;
                base.WindowState = FormWindowState.Normal;
                this.Size = NormalSize;
            }
            else
            {
                Maximized = true;
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Moving the form
        private void Achievements_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            panel4.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            label4.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            label5.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            label6.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            label7.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void nameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            nameLabel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        #endregion
    }
}
