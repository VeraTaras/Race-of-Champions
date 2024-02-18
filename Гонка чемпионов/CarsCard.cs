using System;
using System.Windows.Forms;
using Гонка_чемпионов.Properties;

namespace Гонка_чемпионов
{
    public partial class CarsCard : Form
    {
        #region Variables
        private Champions champions;

        bool picture1 = true;
        bool picture2 = false;
        bool picture3 = false;

        int Money = (int)Settings.Default["Money"];

        bool EnnyCard = (bool)Settings.Default["EnnyCard"];
        bool ZoeCard = (bool)Settings.Default["ZoeCard"];
        bool SveynCard = (bool)Settings.Default["SveynCard"];
        bool EvelinCard = (bool)Settings.Default["EvelinCard"];

        bool Zoe = (bool)Settings.Default["Zoe"];
        bool Sveyn = (bool)Settings.Default["Sveyn"];
        bool Evelin = (bool)Settings.Default["Evelin"];

        int TanksCount = (int)Settings.Default["TanksCount"];
        int PassenegerCarsCount = (int)Settings.Default["PassenegerCarsCount"];
        int RacingCarsCount = (int)Settings.Default["RacingCarsCount"];
        int CarsCount = (int)Settings.Default["CarsCount"];
        #endregion

        public CarsCard(Champions champions)
        {
            InitializeComponent();
            CardCreate();
            this.champions = champions;
        }

        #region Formalisation
        public void CardCreate()
        {
            moneyLabel.Text = Money.ToString();

            if (EnnyCard)
            {
                nameLabel.Text = "Basic";
                label6.Text = "100 km/hour";
                label4.Text = "FREE";
                buyButton.Text = "Bought";
                buyButton.Enabled = false;
                mainPictureBox.Image = Properties.Resources.Enny;
                pictureBox1.Image = Properties.Resources.Enny;
                pictureBox2.Image = Properties.Resources.Enny2;
                pictureBox3.Image = Properties.Resources.Enny1;
            }
            
            else if (ZoeCard)
            {
                BuyButtonText(Zoe);
                nameLabel.Text = "Passenger";
                label6.Text = "140 km/hour";
                label4.Text = "5 500 coins";
                mainPictureBox.Image = Properties.Resources.Zoe1;
                pictureBox1.Image = Properties.Resources.Zoe1;
                pictureBox2.Image = Properties.Resources.Zoe;
                pictureBox3.Image = Properties.Resources.Zoe2;
                hurtPictureBox2.Image = Properties.Resources.Hurt;
                hurtPictureBox3.Image = Properties.Resources.Hurt;
            }

            else if (SveynCard)
            {
                BuyButtonText(Sveyn);
                nameLabel.Text = "Tank";
                label6.Text = "70 km/hour";
                label4.Text = "5 500 coins";
                mainPictureBox.Image = Properties.Resources.Sveyn1;
                pictureBox1.Image = Properties.Resources.Sveyn1;
                pictureBox2.Image = Properties.Resources.SveynMid;
                pictureBox3.Image = Properties.Resources.Sveyn2;
                hurtPictureBox2.Image = Properties.Resources.Hurt;
                hurtPictureBox3.Image = Properties.Resources.Hurt;
                hurtPictureBox4.Image = Properties.Resources.Hurt;
                hurtPictureBox5.Image = Properties.Resources.Hurt;
            }
            
            else if (EvelinCard)
            {
                BuyButtonText(Evelin);
                nameLabel.Text = "Racing";
                label6.Text = "220 km/hour";
                label4.Text = "5 500 coins";
                mainPictureBox.Image = Properties.Resources.Evelin1;
                pictureBox1.Image = Properties.Resources.Evelin1;
                pictureBox2.Image = Properties.Resources.EvelinMid;
                pictureBox3.Image = Properties.Resources.Evelin2;
                hurtPictureBox2.Image = Properties.Resources.Hurt;
                hurtPictureBox3.Image = Properties.Resources.Hurt;
                hurtPictureBox4.Image = Properties.Resources.Hurt;
            }
        }

        public void BuyButtonText(bool champ)
        {
            if (champ)
            {
                buyButton.Text = "Bought";
                buyButton.Enabled = false;
            }
            else
            {
                buyButton.Text = "Buy";
                buyButton.Enabled = true;
            }
        }
        #endregion

        #region Picture switching
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Picture1();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Picture2();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Picture3();
        }

        private void leftArrowPicture_Click(object sender, EventArgs e)
        {
            if (picture3)
                Picture2();

            else if (picture2)
                Picture1();
        }
        private void rightArrowPicture_Click(object sender, EventArgs e)
        {
            if (picture1)
                Picture2();

            else if (picture2)
                Picture3();
        }

        public void Picture1()
        {
            picture1 = true;
            picture2 = false;
            picture3 = false;

            if (EnnyCard)
                mainPictureBox.Image = Properties.Resources.Enny;

            else if (ZoeCard)
                mainPictureBox.Image = Properties.Resources.Zoe1;

            else if (SveynCard)
                mainPictureBox.Image = Properties.Resources.Sveyn1;

            else if (EvelinCard)
                mainPictureBox.Image = Properties.Resources.Evelin1;
        }

        public void Picture2()
        {
            picture1 = false;
            picture2 = true;
            picture3 = false;

            if (EnnyCard)
                mainPictureBox.Image = Properties.Resources.Enny2;
            
            else if (ZoeCard)
                mainPictureBox.Image = Properties.Resources.Zoe;

            else if (SveynCard)
                mainPictureBox.Image = Properties.Resources.SveynMid;
            
            else if (EvelinCard)
                mainPictureBox.Image = Properties.Resources.EvelinMid;
        }
        public void Picture3()
        {
            picture1 = false;
            picture2 = false;
            picture3 = true;

            if (EnnyCard)
                mainPictureBox.Image = Properties.Resources.Enny1;
           
            else if (ZoeCard)
                mainPictureBox.Image = Properties.Resources.Zoe2;

            else if (SveynCard)
                mainPictureBox.Image = Properties.Resources.Sveyn2;
            
            else if (EvelinCard)
                mainPictureBox.Image = Properties.Resources.Evelin2;
        }
        #endregion

        #region Buttons
        private void buyButton_Click(object sender, EventArgs e)
        {
            if (Money >= 5500)
            {
                CarsCount++;
                Money -= 5500;
                moneyLabel.Text = Money.ToString();

                if (ZoeCard)
                {
                    PassenegerCarsCount++;
                    Zoe = true;
                }

                else if (SveynCard)
                {
                    TanksCount++;
                    Sveyn = true;
                }

                else if (EvelinCard)
                {
                    RacingCarsCount++;
                    Evelin = true;
                }

                BuyButtonText(true);
                champions.CarAvailability(Zoe, Sveyn, Evelin);
            }
            else
                _ = MessageBox.Show("Insufficient funds");
        }
       
        private void closeButton_Click(object sender, EventArgs e)
        {
            DataSave();
            champions.CardZeroing();
            Hide();
        }
        #endregion

        public void DataSave()
        {
            Settings.Default["Money"] = Money;

            Settings.Default["Zoe"] = Zoe;
            Settings.Default["Sveyn"] = Sveyn;
            Settings.Default["Evelin"] = Evelin;

            Settings.Default["TanksCount"] = TanksCount;
            Settings.Default["PassenegerCarsCount"] = PassenegerCarsCount;
            Settings.Default["RacingCarsCount"] = RacingCarsCount;
            Settings.Default["CarsCount"] = CarsCount;

            Settings.Default.Save();
        }
    }
}
