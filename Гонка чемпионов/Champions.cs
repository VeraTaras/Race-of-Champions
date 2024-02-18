using System;
using System.Drawing;
using System.Windows.Forms;
using Гонка_чемпионов.Properties;

namespace Гонка_чемпионов
{
    public partial class Champions : Form
    {
        #region Variables
        bool Maximized = (bool)Settings.Default["Maximized"];
        Size NormalSize = (Size)Settings.Default["NormalSize"];

        bool EnnyCard = (bool)Settings.Default["EnnyCard"];
        bool ZoeCard = (bool)Settings.Default["ZoeCard"];
        bool SveynCard = (bool)Settings.Default["SveynCard"];
        bool EvelinCard = (bool)Settings.Default["EvelinCard"];

        bool Zoe = (bool)Settings.Default["Zoe"];
        bool Sveyn = (bool)Settings.Default["Sveyn"];
        bool Evelin = (bool)Settings.Default["Evelin"];

        bool EnnyChoose = (bool)Settings.Default["EnnyChoose"];
        bool ZoeChoose = (bool)Settings.Default["ZoeChoose"];
        bool SveynChoose = (bool)Settings.Default["SveynChoose"];
        bool EvelinChoose = (bool)Settings.Default["EvelinChoose"];
        #endregion

        public Champions()
        {
            InitializeComponent();

            CarAvailability(Zoe, Sveyn, Evelin);
            ActiveTask();
        }

        #region Formalisation
        public void CarAvailability(bool zoe, bool sveyn, bool evelin)
        {
            if (zoe)
                buyButton2.Enabled = true;

            if (sveyn)
                buyButton3.Enabled = true;

            if (evelin)
                buyButton4.Enabled = true;
        }

        public void ActiveTask()
        {
            taskPictureBox1.Visible = false;
            taskPictureBox2.Visible = false;
            taskPictureBox3.Visible = false;
            taskPictureBox4.Visible = false;

            if (EnnyChoose)
                taskPictureBox1.Visible = true;

            else if (ZoeChoose)
                taskPictureBox2.Visible = true;

            else if (SveynChoose)
                taskPictureBox3.Visible = true;

            else if (EvelinChoose)
                taskPictureBox4.Visible = true;
        }
        #endregion

        #region Saves
        public void DataSave()
        {
            Settings.Default["EnnyCard"] = EnnyCard;
            Settings.Default["ZoeCard"] = ZoeCard;
            Settings.Default["SveynCard"] = SveynCard;
            Settings.Default["EvelinCard"] = EvelinCard;

            Settings.Default["EnnyChoose"] = EnnyChoose;
            Settings.Default["ZoeChoose"] = ZoeChoose;
            Settings.Default["SveynChoose"] = SveynChoose;
            Settings.Default["EvelinChoose"] = EvelinChoose;

            Settings.Default.Save();
        }

        public void CardZeroing()
        {
            EnnyCard = false;
            ZoeCard = false;
            SveynCard = false;
            EvelinCard = false;
        }

        public void CarZeroing()
        {
            EnnyChoose = false;
            ZoeChoose = false;
            SveynChoose = false;
            EvelinChoose = false;
        }

        public void Zeroing()
        {
            Settings.Default["Maximized"] = false;
            Settings.Default["FirstGameOpening"] = 0;

            Settings.Default.Save();
        }
        #endregion

        #region Clicking on the picture
        public void CardOpen()
        {
            DataSave();
            CarsCard card = new CarsCard(this);
            card.ShowDialog();
        }

        private void carPictureBox1_Click(object sender, EventArgs e)
        {
            EnnyCard = true;
            CardOpen();
        }

        private void carPictureBox3_Click(object sender, EventArgs e)
        {
            ZoeCard = true;
            CardOpen();
        }

        private void carPictureBox4_Click(object sender, EventArgs e)
        {
            SveynCard = true;
            CardOpen();
        }

        private void carPictureBox4_Click_1(object sender, EventArgs e)
        {
            EvelinCard = true;
            CardOpen();
        }
        #endregion

        #region Usage buttons
        bool UseButton()
        {
            CarZeroing();
            return true;
        }

        private void buyButton1_Click(object sender, EventArgs e)
        {
            EnnyChoose = UseButton();
            ActiveTask();
        }

        private void buyButton2_Click(object sender, EventArgs e)
        {
            ZoeChoose = UseButton();
            ActiveTask();
        }

        private void buyButton3_Click(object sender, EventArgs e)
        {
            SveynChoose = UseButton();
            ActiveTask();
        }

        private void buyButton4_Click(object sender, EventArgs e)
        {
            EvelinChoose = UseButton();
            ActiveTask();
        }
        #endregion

        #region Technical buttons
        private void menuButton_Click(object sender, EventArgs e)
        {
            Settings.Default["Maximized"] = Maximized;
            DataSave();
            Menu menu = new Menu();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = Location;
            menu.Size = Size;
            menu.Show();
            Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DataSave();
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

        private void Champions_MouseDown(object sender, MouseEventArgs e)
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

        private void categoryLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            categoryLabel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void categoryLabel2_MouseDown(object sender, MouseEventArgs e)
        {
            categoryLabel2.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void categoryLabel3_MouseDown(object sender, MouseEventArgs e)
        {
            categoryLabel3.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void categoryLabel4_MouseDown(object sender, MouseEventArgs e)
        {
            categoryLabel4.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        #endregion
    }
}
