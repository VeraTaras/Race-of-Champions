using System;
using System.Drawing;
using System.Windows.Forms;
using Гонка_чемпионов.Properties;

namespace Гонка_чемпионов
{
    public partial class Menu : Form
    {
        bool Maximized = (bool)Settings.Default["Maximized"];
        Size NormalSize = (Size)Settings.Default["NormalSize"];
        int FirstGameOpening = (int)Settings.Default["FirstGameOpening"];

        public Menu()
        {
            InitializeComponent();

            if (FirstGameOpening == 0)
            {
                Opacity = 0;
                var timer = new System.Windows.Forms.Timer();
                timer.Tick += new EventHandler((sender, e) =>
                {
                    if ((Opacity += 0.05d) == 1) timer.Stop();
                });
                timer.Interval = 100;
                timer.Start();

                NormalSize = this.Size;
            }

            FirstGameOpening++;
        }

        #region Saves
        public void TemporarySave()
        {
            Settings.Default["Maximized"] = Maximized;
            Settings.Default["NormalSize"] = NormalSize;
            Settings.Default["FirstGameOpening"] = FirstGameOpening;

            Settings.Default.Save();

        }

        public void Zeroing()
        {
            Settings.Default["Maximized"] = false;
            Settings.Default["FirstGameOpening"] = 0;

            Settings.Default.Save();
        }
        #endregion

        #region Main buttons
        private void startButton_Click(object sender, EventArgs e)
        {
            TemporarySave();
            Game game = new Game();
            game.StartPosition = FormStartPosition.CenterScreen;
            Complexity complexity = new Complexity(game, this);
            complexity.ShowDialog();
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            TemporarySave();
            Rules rules = new Rules();
            rules.StartPosition = FormStartPosition.Manual;
            rules.Location = Location;
            rules.Size = Size;
            rules.Show();
            Hide();
        }

        private void championsButton_Click(object sender, EventArgs e)
        {
            TemporarySave();
            Champions champions = new Champions();
            champions.StartPosition = FormStartPosition.Manual;
            champions.Location = Location;
            champions.Size = Size;
            champions.Show();
            Hide();
        }

        private void achievementsButton_Click(object sender, EventArgs e)
        {
            TemporarySave();
            Achievements achievements = new Achievements();
            achievements.StartPosition = FormStartPosition.Manual;
            achievements.Location = Location;
            achievements.Size = Size;
            achievements.Show();
            Hide();
        }

        #endregion

        #region Technical buttons
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

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
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
