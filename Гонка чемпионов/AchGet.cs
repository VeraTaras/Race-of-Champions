using System;
using System.Windows.Forms;

namespace Гонка_чемпионов
{
    public partial class AchGet : Form
    {
        public AchGet()
        {
            InitializeComponent();

            //this.Location = new Point(1000, 374);
            this.Width = 83;
            this.Height = 83;

            // Плавная загрузка формы

            Opacity = 0;
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timer.Stop();
            });
            timer.Interval = 100;
            timer.Start();
        }

        public void PictureGeneration(int pictureNumber)
        {
            if (pictureNumber == 0)
                pictureBox1.Image = Properties.Resources.free_icon_number_20_9808819;
        }
    }
}
