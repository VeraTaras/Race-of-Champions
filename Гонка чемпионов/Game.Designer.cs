namespace Гонка_чемпионов
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.letTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.hurt2 = new System.Windows.Forms.PictureBox();
            this.hurt3 = new System.Windows.Forms.PictureBox();
            this.hurt4 = new System.Windows.Forms.PictureBox();
            this.hurt5 = new System.Windows.Forms.PictureBox();
            this.hurt1 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.moneyCountsLabel = new System.Windows.Forms.Label();
            this.moneyPanel = new System.Windows.Forms.Panel();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.lossLabel = new System.Windows.Forms.Label();
            this.coinPictureBox = new System.Windows.Forms.PictureBox();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.roadPictureBox2 = new System.Windows.Forms.PictureBox();
            this.roadPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hurt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurt5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            this.moneyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // letTimer
            // 
            this.letTimer.Interval = 3000;
            this.letTimer.Tick += new System.EventHandler(this.letTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Гонка_чемпионов.Properties.Resources.imgonline_com_ua_Resize_6m4Aw75jqeP;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.hurt2);
            this.panel1.Controls.Add(this.hurt3);
            this.panel1.Controls.Add(this.hurt4);
            this.panel1.Controls.Add(this.hurt5);
            this.panel1.Controls.Add(this.hurt1);
            this.panel1.Controls.Add(this.star3);
            this.panel1.Controls.Add(this.star2);
            this.panel1.Controls.Add(this.star1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Controls.Add(this.moneyCountsLabel);
            this.panel1.Controls.Add(this.moneyPanel);
            this.panel1.Controls.Add(this.restartButton);
            this.panel1.Controls.Add(this.lossLabel);
            this.panel1.Controls.Add(this.coinPictureBox);
            this.panel1.Controls.Add(this.carPictureBox);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.startLabel);
            this.panel1.Controls.Add(this.roadPictureBox2);
            this.panel1.Controls.Add(this.roadPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 747);
            this.panel1.TabIndex = 8;
            // 
            // hurt2
            // 
            this.hurt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hurt2.BackColor = System.Drawing.Color.Transparent;
            this.hurt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurt2.Image = global::Гонка_чемпионов.Properties.Resources.Hurt;
            this.hurt2.Location = new System.Drawing.Point(1290, 43);
            this.hurt2.Name = "hurt2";
            this.hurt2.Size = new System.Drawing.Size(47, 47);
            this.hurt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hurt2.TabIndex = 30;
            this.hurt2.TabStop = false;
            this.hurt2.Visible = false;
            // 
            // hurt3
            // 
            this.hurt3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hurt3.BackColor = System.Drawing.Color.Transparent;
            this.hurt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurt3.Image = global::Гонка_чемпионов.Properties.Resources.Hurt;
            this.hurt3.Location = new System.Drawing.Point(1237, 45);
            this.hurt3.Name = "hurt3";
            this.hurt3.Size = new System.Drawing.Size(47, 47);
            this.hurt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hurt3.TabIndex = 29;
            this.hurt3.TabStop = false;
            this.hurt3.Visible = false;
            // 
            // hurt4
            // 
            this.hurt4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hurt4.BackColor = System.Drawing.Color.Transparent;
            this.hurt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurt4.Image = global::Гонка_чемпионов.Properties.Resources.Hurt;
            this.hurt4.Location = new System.Drawing.Point(1184, 45);
            this.hurt4.Name = "hurt4";
            this.hurt4.Size = new System.Drawing.Size(47, 47);
            this.hurt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hurt4.TabIndex = 28;
            this.hurt4.TabStop = false;
            this.hurt4.Visible = false;
            // 
            // hurt5
            // 
            this.hurt5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hurt5.BackColor = System.Drawing.Color.Transparent;
            this.hurt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurt5.Image = global::Гонка_чемпионов.Properties.Resources.Hurt;
            this.hurt5.Location = new System.Drawing.Point(1131, 45);
            this.hurt5.Name = "hurt5";
            this.hurt5.Size = new System.Drawing.Size(47, 47);
            this.hurt5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hurt5.TabIndex = 27;
            this.hurt5.TabStop = false;
            this.hurt5.Visible = false;
            // 
            // hurt1
            // 
            this.hurt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hurt1.BackColor = System.Drawing.Color.Transparent;
            this.hurt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurt1.Image = global::Гонка_чемпионов.Properties.Resources.Hurt;
            this.hurt1.Location = new System.Drawing.Point(1343, 45);
            this.hurt1.Name = "hurt1";
            this.hurt1.Size = new System.Drawing.Size(47, 47);
            this.hurt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hurt1.TabIndex = 26;
            this.hurt1.TabStop = false;
            // 
            // star3
            // 
            this.star3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.star3.BackColor = System.Drawing.Color.Transparent;
            this.star3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star3.Image = global::Гонка_чемпионов.Properties.Resources.free_icon_star_616655;
            this.star3.Location = new System.Drawing.Point(723, 327);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(55, 55);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star3.TabIndex = 25;
            this.star3.TabStop = false;
            this.star3.Visible = false;
            // 
            // star2
            // 
            this.star2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.star2.BackColor = System.Drawing.Color.Transparent;
            this.star2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star2.Image = global::Гонка_чемпионов.Properties.Resources.free_icon_star_616655;
            this.star2.Location = new System.Drawing.Point(671, 327);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(55, 55);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star2.TabIndex = 24;
            this.star2.TabStop = false;
            this.star2.Visible = false;
            // 
            // star1
            // 
            this.star1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.star1.BackColor = System.Drawing.Color.Transparent;
            this.star1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star1.Image = global::Гонка_чемпионов.Properties.Resources.free_icon_star_616655;
            this.star1.Location = new System.Drawing.Point(619, 327);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(55, 55);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1.TabIndex = 23;
            this.star1.TabStop = false;
            this.star1.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.IndianRed;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(579, 492);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(232, 44);
            this.menuButton.TabIndex = 18;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // moneyCountsLabel
            // 
            this.moneyCountsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyCountsLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyCountsLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 14F);
            this.moneyCountsLabel.ForeColor = System.Drawing.Color.Black;
            this.moneyCountsLabel.Location = new System.Drawing.Point(497, 19);
            this.moneyCountsLabel.Name = "moneyCountsLabel";
            this.moneyCountsLabel.Size = new System.Drawing.Size(387, 42);
            this.moneyCountsLabel.TabIndex = 17;
            this.moneyCountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moneyCountsLabel.Visible = false;
            // 
            // moneyPanel
            // 
            this.moneyPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.moneyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyPanel.Controls.Add(this.moneyLabel);
            this.moneyPanel.Controls.Add(this.pictureBox6);
            this.moneyPanel.Location = new System.Drawing.Point(28, 31);
            this.moneyPanel.Name = "moneyPanel";
            this.moneyPanel.Size = new System.Drawing.Size(221, 61);
            this.moneyPanel.TabIndex = 16;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.moneyLabel.ForeColor = System.Drawing.Color.Sienna;
            this.moneyLabel.Location = new System.Drawing.Point(50, 2);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(166, 56);
            this.moneyLabel.TabIndex = 17;
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Гонка_чемпионов.Properties.Resources.free_icon_dollar_6068681;
            this.pictureBox6.Location = new System.Drawing.Point(3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 56);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.IndianRed;
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.restartButton.ForeColor = System.Drawing.Color.White;
            this.restartButton.Location = new System.Drawing.Point(579, 409);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(232, 44);
            this.restartButton.TabIndex = 13;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.BackColor = System.Drawing.Color.IndianRed;
            this.lossLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F);
            this.lossLabel.ForeColor = System.Drawing.Color.White;
            this.lossLabel.Location = new System.Drawing.Point(612, 257);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(166, 47);
            this.lossLabel.TabIndex = 9;
            this.lossLabel.Text = "You lose";
            this.lossLabel.Visible = false;
            // 
            // coinPictureBox
            // 
            this.coinPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.coinPictureBox.BackgroundImage = global::Гонка_чемпионов.Properties.Resources.photo_2023_09_05_22_39_27;
            this.coinPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("coinPictureBox.Image")));
            this.coinPictureBox.Location = new System.Drawing.Point(550, -500);
            this.coinPictureBox.Name = "coinPictureBox";
            this.coinPictureBox.Size = new System.Drawing.Size(67, 67);
            this.coinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinPictureBox.TabIndex = 14;
            this.coinPictureBox.TabStop = false;
            // 
            // carPictureBox
            // 
            this.carPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.carPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.carPictureBox.Image = global::Гонка_чемпионов.Properties.Resources.EnnyCar;
            this.carPictureBox.Location = new System.Drawing.Point(732, 492);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(157, 202);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPictureBox.TabIndex = 6;
            this.carPictureBox.TabStop = false;
            this.carPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.carPictureBox_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Гонка_чемпионов.Properties.Resources.photo_2023_09_05_22_39_27;
            this.pictureBox4.Image = global::Гонка_чемпионов.Properties.Resources.Stone2;
            this.pictureBox4.Location = new System.Drawing.Point(940, -108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(162, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Гонка_чемпионов.Properties.Resources.photo_2023_09_05_22_39_27;
            this.pictureBox3.Image = global::Гонка_чемпионов.Properties.Resources.photo_2023_09_05_22_39_27;
            this.pictureBox3.Location = new System.Drawing.Point(731, -120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Гонка_чемпионов.Properties.Resources.photo_2023_09_05_22_39_27;
            this.pictureBox2.Image = global::Гонка_чемпионов.Properties.Resources.Stone;
            this.pictureBox2.Location = new System.Drawing.Point(503, -108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Гонка_чемпионов.Properties.Resources.photo_2023_09_05_22_39_27;
            this.pictureBox1.Image = global::Гонка_чемпионов.Properties.Resources.Pigeon;
            this.pictureBox1.Location = new System.Drawing.Point(297, -120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // startLabel
            // 
            this.startLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.DimGray;
            this.startLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.Linen;
            this.startLabel.Location = new System.Drawing.Point(432, 204);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(534, 63);
            this.startLabel.TabIndex = 8;
            this.startLabel.Text = "Click on the inscription";
            this.startLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startLabel_MouseClick);
            // 
            // roadPictureBox2
            // 
            this.roadPictureBox2.Image = global::Гонка_чемпионов.Properties.Resources._1623480034_7_phonoteka_org_p_doroga_vid_sverkhu_tekstura_krasivo_9;
            this.roadPictureBox2.Location = new System.Drawing.Point(0, -747);
            this.roadPictureBox2.Name = "roadPictureBox2";
            this.roadPictureBox2.Size = new System.Drawing.Size(1402, 747);
            this.roadPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadPictureBox2.TabIndex = 7;
            this.roadPictureBox2.TabStop = false;
            this.roadPictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roadPictureBox2_MouseDown);
            // 
            // roadPictureBox
            // 
            this.roadPictureBox.Image = global::Гонка_чемпионов.Properties.Resources._1623480034_7_phonoteka_org_p_doroga_vid_sverkhu_tekstura_krasivo_9;
            this.roadPictureBox.Location = new System.Drawing.Point(0, 0);
            this.roadPictureBox.Name = "roadPictureBox";
            this.roadPictureBox.Size = new System.Drawing.Size(1402, 747);
            this.roadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadPictureBox.TabIndex = 5;
            this.roadPictureBox.TabStop = false;
            this.roadPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roadPictureBox_MouseDown);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 747);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hurt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurt5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            this.moneyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox roadPictureBox;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.PictureBox roadPictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer letTimer;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox coinPictureBox;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel moneyPanel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label moneyCountsLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox hurt2;
        private System.Windows.Forms.PictureBox hurt3;
        private System.Windows.Forms.PictureBox hurt4;
        private System.Windows.Forms.PictureBox hurt5;
        private System.Windows.Forms.PictureBox hurt1;
    }
}