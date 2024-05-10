namespace Hotel_Manager
{
    partial class FoodMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenu));
            foodPanel = new MetroFramework.Controls.MetroPanel();
            launchQt = new TextBox();
            dinnerQTY = new TextBox();
            breakfastQTY = new TextBox();
            dinnerPicture = new PictureBox();
            lunchPicture = new PictureBox();
            breakfastPicture = new PictureBox();
            dinnerCheckBox = new MetroFramework.Controls.MetroCheckBox();
            lunchCheckBox = new MetroFramework.Controls.MetroCheckBox();
            breakfastCheckBox = new MetroFramework.Controls.MetroCheckBox();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            needPanel = new MetroFramework.Controls.MetroPanel();
            surpriseCheckBox = new MetroFramework.Controls.MetroCheckBox();
            towelsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            cleaningCheckBox = new MetroFramework.Controls.MetroCheckBox();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            nextButton = new MetroFramework.Controls.MetroButton();
            foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).BeginInit();
            needPanel.SuspendLayout();
            SuspendLayout();
            // 
            // foodPanel
            // 
            foodPanel.BackColor = Color.FromArgb(225, 225, 225);
            foodPanel.BackgroundImageLayout = ImageLayout.None;
            foodPanel.Controls.Add(launchQt);
            foodPanel.Controls.Add(dinnerQTY);
            foodPanel.Controls.Add(breakfastQTY);
            foodPanel.Controls.Add(dinnerPicture);
            foodPanel.Controls.Add(lunchPicture);
            foodPanel.Controls.Add(breakfastPicture);
            foodPanel.Controls.Add(dinnerCheckBox);
            foodPanel.Controls.Add(lunchCheckBox);
            foodPanel.Controls.Add(breakfastCheckBox);
            foodPanel.Controls.Add(metroLabel1);
            foodPanel.HorizontalScrollbarBarColor = true;
            foodPanel.HorizontalScrollbarHighlightOnWheel = false;
            foodPanel.HorizontalScrollbarSize = 15;
            foodPanel.Location = new Point(19, 97);
            foodPanel.Margin = new Padding(4, 5, 4, 5);
            foodPanel.Name = "foodPanel";
            foodPanel.Size = new Size(443, 565);
            foodPanel.TabIndex = 5;
            foodPanel.UseCustomBackColor = true;
            foodPanel.UseCustomForeColor = true;
            foodPanel.UseStyleColors = true;
            foodPanel.VerticalScrollbarBarColor = true;
            foodPanel.VerticalScrollbarHighlightOnWheel = false;
            foodPanel.VerticalScrollbarSize = 13;
            // 
            // launchQt
            // 
            launchQt.Location = new Point(251, 283);
            launchQt.Name = "launchQt";
            launchQt.Size = new Size(125, 27);
            launchQt.TabIndex = 12;
            // 
            // dinnerQTY
            // 
            dinnerQTY.Location = new Point(19, 512);
            dinnerQTY.Name = "dinnerQTY";
            dinnerQTY.Size = new Size(125, 27);
            dinnerQTY.TabIndex = 11;
            // 
            // breakfastQTY
            // 
            breakfastQTY.Location = new Point(19, 283);
            breakfastQTY.Name = "breakfastQTY";
            breakfastQTY.Size = new Size(125, 27);
            breakfastQTY.TabIndex = 9;
            // 
            // dinnerPicture
            // 
            dinnerPicture.Image = (Image)resources.GetObject("dinnerPicture.Image");
            dinnerPicture.Location = new Point(19, 348);
            dinnerPicture.Margin = new Padding(4, 5, 4, 5);
            dinnerPicture.Name = "dinnerPicture";
            dinnerPicture.Size = new Size(172, 115);
            dinnerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            dinnerPicture.TabIndex = 8;
            dinnerPicture.TabStop = false;
            // 
            // lunchPicture
            // 
            lunchPicture.Image = (Image)resources.GetObject("lunchPicture.Image");
            lunchPicture.Location = new Point(229, 85);
            lunchPicture.Margin = new Padding(4, 5, 4, 5);
            lunchPicture.Name = "lunchPicture";
            lunchPicture.Size = new Size(192, 142);
            lunchPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lunchPicture.TabIndex = 7;
            lunchPicture.TabStop = false;
            // 
            // breakfastPicture
            // 
            breakfastPicture.Image = (Image)resources.GetObject("breakfastPicture.Image");
            breakfastPicture.Location = new Point(19, 85);
            breakfastPicture.Margin = new Padding(4, 5, 4, 5);
            breakfastPicture.Name = "breakfastPicture";
            breakfastPicture.Size = new Size(172, 142);
            breakfastPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            breakfastPicture.TabIndex = 6;
            breakfastPicture.TabStop = false;
            // 
            // dinnerCheckBox
            // 
            dinnerCheckBox.AutoSize = true;
            dinnerCheckBox.BackColor = Color.Transparent;
            dinnerCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            dinnerCheckBox.Location = new Point(19, 472);
            dinnerCheckBox.Margin = new Padding(4, 5, 4, 5);
            dinnerCheckBox.Name = "dinnerCheckBox";
            dinnerCheckBox.Size = new Size(115, 20);
            dinnerCheckBox.TabIndex = 5;
            dinnerCheckBox.Text = "Dinner   ($15)";
            dinnerCheckBox.UseCustomBackColor = true;
            dinnerCheckBox.UseSelectable = true;
            dinnerCheckBox.UseVisualStyleBackColor = false;
            dinnerCheckBox.CheckedChanged += dinnerCheckBox_CheckedChanged;
            // 
            // lunchCheckBox
            // 
            lunchCheckBox.AutoSize = true;
            lunchCheckBox.BackColor = Color.Transparent;
            lunchCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            lunchCheckBox.Location = new Point(229, 240);
            lunchCheckBox.Margin = new Padding(4, 5, 4, 5);
            lunchCheckBox.Name = "lunchCheckBox";
            lunchCheckBox.Size = new Size(109, 20);
            lunchCheckBox.TabIndex = 4;
            lunchCheckBox.Text = "Lunch   ($15)";
            lunchCheckBox.UseCustomBackColor = true;
            lunchCheckBox.UseSelectable = true;
            lunchCheckBox.UseVisualStyleBackColor = false;
            lunchCheckBox.CheckedChanged += lunchCheckBox_CheckedChanged;
            // 
            // breakfastCheckBox
            // 
            breakfastCheckBox.AutoSize = true;
            breakfastCheckBox.BackColor = Color.Transparent;
            breakfastCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            breakfastCheckBox.Location = new Point(19, 240);
            breakfastCheckBox.Margin = new Padding(4, 5, 4, 5);
            breakfastCheckBox.Name = "breakfastCheckBox";
            breakfastCheckBox.Size = new Size(125, 20);
            breakfastCheckBox.TabIndex = 3;
            breakfastCheckBox.Text = "Break Fast  ($7)";
            breakfastCheckBox.UseCustomBackColor = true;
            breakfastCheckBox.UseSelectable = true;
            breakfastCheckBox.UseVisualStyleBackColor = false;
            breakfastCheckBox.CheckedChanged += breakfastCheckBox_CheckedChanged;
            // 
            // metroLabel1
            // 
            metroLabel1.BackColor = Color.Transparent;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel1.Location = new Point(4, 15);
            metroLabel1.Margin = new Padding(4, 0, 4, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(231, 43);
            metroLabel1.TabIndex = 2;
            metroLabel1.Text = "Food Selection";
            metroLabel1.UseCustomBackColor = true;
            // 
            // needPanel
            // 
            needPanel.BackColor = Color.FromArgb(225, 225, 225);
            needPanel.BackgroundImageLayout = ImageLayout.None;
            needPanel.Controls.Add(surpriseCheckBox);
            needPanel.Controls.Add(towelsCheckBox);
            needPanel.Controls.Add(cleaningCheckBox);
            needPanel.Controls.Add(metroLabel2);
            needPanel.HorizontalScrollbarBarColor = true;
            needPanel.HorizontalScrollbarHighlightOnWheel = false;
            needPanel.HorizontalScrollbarSize = 15;
            needPanel.Location = new Point(473, 97);
            needPanel.Margin = new Padding(4, 5, 4, 5);
            needPanel.Name = "needPanel";
            needPanel.Size = new Size(219, 502);
            needPanel.TabIndex = 6;
            needPanel.UseCustomBackColor = true;
            needPanel.UseCustomForeColor = true;
            needPanel.UseStyleColors = true;
            needPanel.VerticalScrollbarBarColor = true;
            needPanel.VerticalScrollbarHighlightOnWheel = false;
            needPanel.VerticalScrollbarSize = 13;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.AutoSize = true;
            surpriseCheckBox.BackColor = Color.Transparent;
            surpriseCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            surpriseCheckBox.Location = new Point(24, 197);
            surpriseCheckBox.Margin = new Padding(4, 5, 4, 5);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new Size(139, 20);
            surpriseCheckBox.TabIndex = 44;
            surpriseCheckBox.Text = "Sweetest surprise";
            surpriseCheckBox.UseCustomBackColor = true;
            surpriseCheckBox.UseSelectable = true;
            surpriseCheckBox.UseVisualStyleBackColor = false;
            // 
            // towelsCheckBox
            // 
            towelsCheckBox.AutoSize = true;
            towelsCheckBox.BackColor = Color.Transparent;
            towelsCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            towelsCheckBox.Location = new Point(24, 140);
            towelsCheckBox.Margin = new Padding(4, 5, 4, 5);
            towelsCheckBox.Name = "towelsCheckBox";
            towelsCheckBox.Size = new Size(70, 20);
            towelsCheckBox.TabIndex = 42;
            towelsCheckBox.Text = "Towels";
            towelsCheckBox.UseCustomBackColor = true;
            towelsCheckBox.UseSelectable = true;
            towelsCheckBox.UseVisualStyleBackColor = false;
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.AutoSize = true;
            cleaningCheckBox.BackColor = Color.Transparent;
            cleaningCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            cleaningCheckBox.Location = new Point(24, 85);
            cleaningCheckBox.Margin = new Padding(4, 5, 4, 5);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new Size(83, 20);
            cleaningCheckBox.TabIndex = 41;
            cleaningCheckBox.Text = "Cleaning";
            cleaningCheckBox.UseCustomBackColor = true;
            cleaningCheckBox.UseSelectable = true;
            cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // metroLabel2
            // 
            metroLabel2.BackColor = Color.Transparent;
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel2.Location = new Point(4, 15);
            metroLabel2.Margin = new Padding(4, 0, 4, 0);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(161, 43);
            metroLabel2.TabIndex = 41;
            metroLabel2.Text = "Special needs";
            metroLabel2.UseCustomBackColor = true;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(473, 609);
            nextButton.Margin = new Padding(4, 5, 4, 5);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(219, 52);
            nextButton.TabIndex = 45;
            nextButton.Text = "Next";
            nextButton.UseSelectable = true;
            nextButton.Click += nextButton_Click;
            // 
            // FoodMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 680);
            Controls.Add(nextButton);
            Controls.Add(needPanel);
            Controls.Add(foodPanel);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FoodMenu";
            Padding = new Padding(27, 92, 27, 31);
            Resizable = false;
            ShowInTaskbar = false;
            Text = "Food and Menu";
            foodPanel.ResumeLayout(false);
            foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).EndInit();
            needPanel.ResumeLayout(false);
            needPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel foodPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox dinnerPicture;
        private System.Windows.Forms.PictureBox lunchPicture;
        private System.Windows.Forms.PictureBox breakfastPicture;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroCheckBox dinnerCheckBox;
        public MetroFramework.Controls.MetroCheckBox lunchCheckBox;
        public MetroFramework.Controls.MetroCheckBox breakfastCheckBox;
        public MetroFramework.Controls.MetroCheckBox surpriseCheckBox;
        public MetroFramework.Controls.MetroCheckBox towelsCheckBox;
        public MetroFramework.Controls.MetroCheckBox cleaningCheckBox;
        public MetroFramework.Controls.MetroPanel needPanel;
        public MetroFramework.Controls.MetroButton nextButton;
        public TextBox breakfastQTY;
        public TextBox dinnerQTY;
        public TextBox launchQt;
    }
}