using System;
using System.Drawing;
using System.Windows.Forms;
using Гонка_чемпионов.Properties;

namespace Гонка_чемпионов
{
    public partial class Game : Form
    {
        #region Variables
        bool EnnyChoose = (bool)Settings.Default["EnnyChoose"];
        bool ZoeChoose = (bool)Settings.Default["ZoeChoose"];
        bool SveynChoose = (bool)Settings.Default["SveynChoose"];
        bool EvelinChoose = (bool)Settings.Default["EvelinChoose"];

        Random random = new Random();
        int roadSpeed;
        int roadHeight;
        int coinPosition1 = 260;
        int coinPosition2 = 420;
        int coinPosition3 = 590;
        int coinPosition4 = 750;
        int coinsCount;
        bool let1 = false;
        bool let2 = false;
        bool let3 = false;
        bool let4 = false;
        bool loss = true;
        bool coinsBag = false;

        int StartsCount = (int)Settings.Default["StartsCount"];
        int Money = (int)Settings.Default["Money"];
        int AllMoney = (int)Settings.Default["AllMoney"];
        Size NormalSize = (Size)Settings.Default["NormalSize"];
        bool ach2 = (bool)Settings.Default["ach2"];
        bool ach3 = (bool)Settings.Default["ach3"];

        bool Complexity1;
        bool Complexity2;
        bool Complexity3;

        int livesCount;
        #endregion

        public Game()
        {
            InitializeComponent();

            #region Champion
            if (EnnyChoose)
            {
                carPictureBox.Image = Properties.Resources.EnnyCar;
                roadSpeed = 12;
                livesCount = 1;
            }
            
            else if (ZoeChoose)
            {
                carPictureBox.Image = Properties.Resources.Zoe;
                roadSpeed = 15;
                livesCount = 3;
                hurt2.Visible = true;
                hurt3.Visible = true;
            }

            else if (SveynChoose)
            {
                carPictureBox.Image = Properties.Resources.Sveyn;
                carPictureBox.Size = new Size(129, 143);
                carPictureBox.Location = new Point(carPictureBox.Left - 5, carPictureBox.Top);
                roadSpeed = 8;
                livesCount = 5;
                hurt2.Visible = true;
                hurt3.Visible = true;
                hurt4.Visible = true;
                hurt5.Visible = true;
            }
            
            else if (EvelinChoose)
            {
                carPictureBox.Image = Properties.Resources.Evelin;
                carPictureBox.Size = new Size(85, 160);
                carPictureBox.Location = new Point(carPictureBox.Left + 15, carPictureBox.Top);
                roadSpeed = 22;
                livesCount = 4;
                hurt2.Visible = true;
                hurt3.Visible = true;
                hurt4.Visible = true;
            }
            #endregion

            #region Formalisation
            roadHeight = roadPictureBox.Height;
            KeyPreview = true;
            #endregion

            #region Coins
            moneyLabel.Text = coinsCount.ToString();
            moneyCountsLabel.Text = "Total number of coins: " + Money.ToString();

            int coinPosition = CoinLocation();

            if (coinPosition == 1)
                coinPictureBox.Location = new Point(coinPosition1, -500);

            else if (coinPosition == 2)
                coinPictureBox.Location = new Point(coinPosition2, -500);

            else if (coinPosition == 3)
                coinPictureBox.Location = new Point(coinPosition3, -500);

            else
                coinPictureBox.Location = new Point(coinPosition4, -500);
            #endregion
        }

        #region Timers
        private void timer_Tick(object sender, EventArgs e)
        {
            roadPictureBox2.Top += roadSpeed;
            roadPictureBox.Top += roadSpeed;

            if (roadPictureBox.Top >= roadHeight)
            {
                roadPictureBox.Top = 0;
                roadPictureBox2.Top = -roadHeight;
            }

            #region Coin movement
            if (coinPictureBox.Bounds.IntersectsWith(pictureBox1.Bounds) ||
                coinPictureBox.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                coinPictureBox.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                coinPictureBox.Bounds.IntersectsWith(pictureBox4.Bounds))
                coinPictureBox.Visible = false;

            else
                coinPictureBox.Visible = true;

            coinPictureBox.Top += roadSpeed;

            if (coinPictureBox.Top >= roadHeight)
                CoinReturn();
            #endregion

            #region Obstacle movement
            int emergencyHeight = roadHeight + 70;

            if (let1)
            {
                pictureBox1.Top += roadSpeed;

                if (pictureBox1.Top >= emergencyHeight)
                {
                    pictureBox1.Top = -roadHeight;
                    pictureBox1.Visible = false;
                    let1 = false;
                }
            }

            if (let2)
            {
                pictureBox2.Top += roadSpeed;

                if (pictureBox2.Top >= emergencyHeight)
                {
                    pictureBox2.Top = -roadHeight;
                    pictureBox2.Visible = false;
                    let2 = false;
                }
            }

            if (let3)
            {
                pictureBox3.Top += roadSpeed;

                if (pictureBox3.Top >= emergencyHeight)
                {
                    pictureBox3.Top = -roadHeight;
                    pictureBox3.Visible = false;
                    let3 = false;
                }
            }

            if (let4)
            {
                pictureBox4.Top += roadSpeed;

                if (pictureBox4.Top >= emergencyHeight)
                {
                    pictureBox4.Top = -roadHeight;
                    pictureBox4.Visible = false;
                    let4 = false;
                }
            }
            #endregion

            #region Collision

            if (carPictureBox.Bounds.IntersectsWith(pictureBox1.Bounds)
                || carPictureBox.Bounds.IntersectsWith(pictureBox2.Bounds)
                || carPictureBox.Bounds.IntersectsWith(pictureBox3.Bounds)
                || carPictureBox.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                if (livesCount == 1)
                    Death();

                else if (livesCount == 2)
                {
                    Restart();
                    hurt2.Image = Properties.Resources.BlackHurt;
                }

                else if (livesCount == 3)
                {
                    Restart();
                    hurt3.Image = Properties.Resources.BlackHurt;
                }

                else if (livesCount == 4)
                {
                    Restart();
                    hurt4.Image = Properties.Resources.BlackHurt;
                }

                else if (livesCount == 5)
                {
                    Restart();
                    hurt5.Image = Properties.Resources.BlackHurt;
                }

                livesCount--;
            }
            #endregion

            #region Coin counting
            if (carPictureBox.Bounds.IntersectsWith(coinPictureBox.Bounds))
            {
                if (Complexity1)
                    CoinsAdd(1, 20);

                else if (Complexity2)
                    CoinsAdd(5, 100);

                else
                    CoinsAdd(20, 400);


                moneyLabel.Text = coinsCount.ToString();
                CoinReturn();
            }
            #endregion
        }

        private void letTimer_Tick(object sender, EventArgs e)
        {
            LetGeneration();
        }
        #endregion

        #region Keys
        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                DataSave();
                Application.Exit();
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (loss)
                return;

            int coefficient1 = 218;
            int coefficirnt2 = 713;

            if (EnnyChoose || ZoeChoose)
                CarMove(sender, e, coefficient1 + 2, coefficirnt2 - 5);

            if (SveynChoose)
                CarMove(sender, e, coefficient1, coefficirnt2 - 5);

            else if (EvelinChoose)
                CarMove(sender, e, coefficient1 + 17, coefficirnt2);
        }

        public void CarMove(object sender, KeyEventArgs e, int coefficient1, int coefficient2)
        {
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && carPictureBox.Left > coefficient1)
                carPictureBox.Left -= 165;

            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) & carPictureBox.Left < coefficient2)
                carPictureBox.Left += 165;
        }
        #endregion

        #region Buttons
        private void startLabel_MouseClick(object sender, MouseEventArgs e)
        {
            startLabel.Visible = false;
            timer.Enabled = true;
            letTimer.Enabled = true;
            loss = false;
            LetGeneration();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Restart();
            StartsCount++;
            timer.Enabled = true;
            letTimer.Enabled = true;
            lossLabel.Visible = false;
            restartButton.Visible = false;
            menuButton.Visible = false;
            moneyCountsLabel.Visible = false;
            loss = false;
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            coinsCount = 0;
            moneyLabel.Text = coinsCount.ToString();
            hurt1.Image = Properties.Resources.Hurt;

            if (EnnyChoose)
                livesCount = 1;

            else if (ZoeChoose)
            {
                livesCount = 3;
                hurt2.Image = Properties.Resources.Hurt;
                hurt3.Image = Properties.Resources.Hurt;
            }

            else if (SveynChoose)
            {
                livesCount = 5;
                hurt2.Image = Properties.Resources.Hurt;
                hurt3.Image = Properties.Resources.Hurt;
                hurt4.Image = Properties.Resources.Hurt;
                hurt5.Image = Properties.Resources.Hurt;
            }

            else if (EvelinChoose)
            {
                livesCount = 4;
                hurt2.Image = Properties.Resources.Hurt;
                hurt3.Image = Properties.Resources.Hurt;
                hurt4.Image = Properties.Resources.Hurt;
            }

            LetGeneration();
            CoinReturn();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            StartsCount++;
            DataSave();
            Menu menu = new Menu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Size = NormalSize;
            menu.Show();
            Hide();
        }
        #endregion

        #region Obstacles
        public void LetGeneration()
        {
            int let = random.Next(1, 5);

            if ((let == 1 && !let1) || (let == 2 && !let2) || (let == 3 && !let3) || (let == 4 && !let4))  //если эта картинка ещё не в движении
            {
                int picture = random.Next(1, 7);

                PictureBox[] pictureBox = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };

                if (picture == 1)
                {
                    pictureBox[let - 1].Image = Properties.Resources.Stone;
                    pictureBox[let - 1].Size = new Size(122, 68);

                }
                else if (picture == 2)
                {

                    pictureBox[let - 1].Image = Properties.Resources.Stone2;
                    pictureBox[let - 1].Size = new Size(112, 58);
                }
                else if (picture == 3)
                {
                    pictureBox[let - 1].Image = Properties.Resources.Pigeon;
                    pictureBox[let - 1].Size = new Size(112, 90);
                }
                else if (picture == 4)
                {
                    pictureBox[let - 1].Image = Properties.Resources.Pigeon2;
                    pictureBox[let - 1].Size = new Size(97, 90);
                }
                else if (picture == 5)
                {
                    pictureBox[let - 1].Image = Properties.Resources.Pigeon3;
                    pictureBox[let - 1].Size = new Size(97, 90);
                }
                else if (picture == 6)
                {
                    pictureBox[let - 1].Image = Properties.Resources.Pigeon4;
                    pictureBox[let - 1].Size = new Size(97, 90);
                }
                else if (picture == 7)
                {
                    pictureBox[let - 1].Image = Properties.Resources.Pigeon5;
                    pictureBox[let - 1].Size = new Size(97, 70);
                }

                if (let == 1)
                {
                    pictureBox1.Visible = true;
                    let1 = true;
                }
                else if (let == 2)
                {
                    pictureBox2.Visible = true;
                    let2 = true;
                }
                else if (let == 3)
                {
                    pictureBox3.Visible = true;
                    let3 = true;
                }
                else
                {
                    pictureBox4.Visible = true;
                    let4 = true;
                }
            }
        }

        public void LetInterval()
        {
            Complexity1 = (bool)Settings.Default["Complexity1"];
            Complexity2 = (bool)Settings.Default["Complexity2"];
            Complexity3 = (bool)Settings.Default["Complexity3"];

            if (Complexity1)
                letTimer.Interval = 4000;
            else if (Complexity3)
                letTimer.Interval = 300;
            else
                letTimer.Interval = 3000;
        }
        #endregion

        #region Coins
        int CoinLocation()
        {
            int coinPosition = random.Next(1, 5);
            return coinPosition;
        }

        public void CoinReturn()
        {
            int coinPosition = CoinLocation();

            if (coinPosition == 1)
                coinPictureBox.Location = new Point(coinPosition1, -100);
            else if (coinPosition == 2)
                coinPictureBox.Location = new Point(coinPosition2, -100);
            else if (coinPosition == 3)
                coinPictureBox.Location = new Point(coinPosition3, -100);
            else
                coinPictureBox.Location = new Point(coinPosition4, -100);

            int prob = random.Next(1, 5);
            if (prob == 3)
            {
                coinPictureBox.Image = Properties.Resources.Coins;
                coinsBag = true;
            }
            else
            {
                coinPictureBox.Image = Properties.Resources.Coin;
                coinsBag = false;
            }
        }

        public void CoinsAdd(int coin, int bagCoin)
        {
            if (coinsBag)
                coinsCount += bagCoin;
            else
                coinsCount += coin;
        }
        #endregion

        #region Restart
        public void Death()
        {
            if ((coinsCount >= 5500) && Complexity3 && EnnyChoose)
                ach2 = true;

            if ((coinsCount >= 10000) && EvelinChoose && Complexity3)
                ach3 = true;

            Money += coinsCount;
            AllMoney += coinsCount;
            moneyCountsLabel.Text = "Total number of coins: " + Money.ToString();
            timer.Enabled = false;
            letTimer.Enabled = false;
            lossLabel.Visible = true;
            restartButton.Visible = true;
            menuButton.Visible = true;
            moneyCountsLabel.Visible = true;
            loss = true;
            hurt1.Image = Properties.Resources.BlackHurt;

            if (Complexity1)
                star2.Visible = true;

            else if (Complexity2)
            {
                star1.Visible = true;
                star3.Visible = true;
            }

            else
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
            }
        }

        public void Restart()
        {
            pictureBox1.Top = -pictureBox1.Height;
            pictureBox2.Top = -pictureBox2.Height;
            pictureBox3.Top = -pictureBox3.Height;
            pictureBox4.Top = -pictureBox4.Height;

            let1 = false;
            let2 = false;
            let3 = false;
            let4 = false;
        }
        #endregion

        public void DataSave()
        {
            Settings.Default["Money"] = Money;
            Settings.Default["AllMoney"] = AllMoney;
            Settings.Default["ach2"] = ach2;
            Settings.Default["ach3"] = ach3;
            Settings.Default["StartsCount"] = StartsCount;

            Settings.Default.Save();
        }

        #region Moving the form
        private void roadPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            roadPictureBox.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void carPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            carPictureBox.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void roadPictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            roadPictureBox2.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }


        #endregion
    }
}
