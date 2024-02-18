using System;
using System.Drawing;
using System.Windows.Forms;
using Гонка_чемпионов.Properties;

namespace Гонка_чемпионов
{
    public partial class Rules : Form
    {

        bool Maximized = (bool)Settings.Default["Maximized"];
        Size NormalSize = (Size)Settings.Default["NormalSize"];

        public Rules()
        {
            InitializeComponent();
        }


        public void Zeroing()
        {
            Settings.Default["Maximized"] = false;
            Settings.Default["FirstGameOpening"] = 0;

            Settings.Default.Save();
        }

        #region Technical buttons
        private void menuButton_Click(object sender, EventArgs e)
        {
            Settings.Default["Maximized"] = Maximized;
            Settings.Default.Save();
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

        private void Rules_MouseDown(object sender, MouseEventArgs e)
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

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Capture = false;
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
