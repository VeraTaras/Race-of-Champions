namespace Гонка_чемпионов
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.collapseButton = new System.Windows.Forms.Button();
            this.expandButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.championsButton = new System.Windows.Forms.Button();
            this.achievementsButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.collapseButton);
            this.panel1.Controls.Add(this.expandButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // collapseButton
            // 
            this.collapseButton.BackColor = System.Drawing.Color.Transparent;
            this.collapseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collapseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.collapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.collapseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collapseButton.Image = global::Гонка_чемпионов.Properties.Resources.Collapse_photo;
            this.collapseButton.Location = new System.Drawing.Point(1098, 0);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(42, 40);
            this.collapseButton.TabIndex = 22;
            this.collapseButton.UseVisualStyleBackColor = false;
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            // 
            // expandButton
            // 
            this.expandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.expandButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.expandButton.Image = ((System.Drawing.Image)(resources.GetObject("expandButton.Image")));
            this.expandButton.Location = new System.Drawing.Point(1140, 0);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(38, 40);
            this.expandButton.TabIndex = 20;
            this.expandButton.UseVisualStyleBackColor = true;
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1178, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(42, 40);
            this.closeButton.TabIndex = 21;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1215, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 702);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 742);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1215, 5);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 707);
            this.panel4.TabIndex = 0;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.nameLabel.Location = new System.Drawing.Point(404, 129);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(452, 65);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Race of Champions";
            this.nameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameLabel_MouseDown);
            // 
            // championsButton
            // 
            this.championsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.championsButton.BackColor = System.Drawing.Color.Transparent;
            this.championsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.championsButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 17.8F);
            this.championsButton.ForeColor = System.Drawing.Color.Salmon;
            this.championsButton.Location = new System.Drawing.Point(475, 491);
            this.championsButton.Name = "championsButton";
            this.championsButton.Size = new System.Drawing.Size(299, 72);
            this.championsButton.TabIndex = 5;
            this.championsButton.Text = "Champions";
            this.championsButton.UseVisualStyleBackColor = false;
            this.championsButton.Click += new System.EventHandler(this.championsButton_Click);
            // 
            // achievementsButton
            // 
            this.achievementsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.achievementsButton.BackColor = System.Drawing.Color.Transparent;
            this.achievementsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.achievementsButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 17F);
            this.achievementsButton.ForeColor = System.Drawing.Color.Salmon;
            this.achievementsButton.Location = new System.Drawing.Point(475, 588);
            this.achievementsButton.Name = "achievementsButton";
            this.achievementsButton.Size = new System.Drawing.Size(299, 72);
            this.achievementsButton.TabIndex = 6;
            this.achievementsButton.Text = "Achievements";
            this.achievementsButton.UseVisualStyleBackColor = false;
            this.achievementsButton.Click += new System.EventHandler(this.achievementsButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 20F);
            this.startButton.ForeColor = System.Drawing.Color.Red;
            this.startButton.Location = new System.Drawing.Point(475, 297);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(299, 72);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Play";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // rulesButton
            // 
            this.rulesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rulesButton.BackColor = System.Drawing.Color.Transparent;
            this.rulesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rulesButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 17F);
            this.rulesButton.ForeColor = System.Drawing.Color.Salmon;
            this.rulesButton.Location = new System.Drawing.Point(475, 392);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(299, 72);
            this.rulesButton.TabIndex = 7;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = false;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1220, 747);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.achievementsButton);
            this.Controls.Add(this.championsButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button championsButton;
        private System.Windows.Forms.Button achievementsButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.Button expandButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button rulesButton;
    }
}

