using System;
using System.Windows.Forms;
using Гонка_чемпионов.Properties;

namespace Гонка_чемпионов
{
    public partial class Complexity : Form
    {
        private Game game;
        private Menu menu;

        bool Complexity1 = false;
        bool Complexity2 = false;
        bool Complexity3 = false;

        int StartsCount = (int)Settings.Default["StartsCount"];


        public Complexity(Game game, Menu menu)
        {
            InitializeComponent();
            this.game = game;
            this.menu = menu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartsCount++;

            if (radioButton1.Checked)
                Complexity1 = true;
            else if (radioButton2.Checked)
                Complexity2 = true;
            else
                Complexity3 = true;

            Settings.Default["Complexity1"] = Complexity1;
            Settings.Default["Complexity2"] = Complexity2;
            Settings.Default["Complexity3"] = Complexity3;
            Settings.Default["StartsCount"] = StartsCount;
            Settings.Default.Save();

            game.LetInterval();
            game.Show();
            menu.Hide();
            Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
