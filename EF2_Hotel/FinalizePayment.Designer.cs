namespace Hotel_Manager
{
    partial class FinalizePayment
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
            nextButton = new MetroFramework.Controls.MetroButton();
            reservation = new MetroFramework.Controls.MetroLabel();
            currentBillAmount = new MetroFramework.Controls.MetroLabel();
            priceLabel = new MetroFramework.Controls.MetroLabel();
            currentBill = new MetroFramework.Controls.MetroLabel();
            paymentLabel = new MetroFramework.Controls.MetroLabel();
            paymentComboBox = new MetroFramework.Controls.MetroComboBox();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            taxAmount = new MetroFramework.Controls.MetroLabel();
            totalLabel = new MetroFramework.Controls.MetroLabel();
            totalAmount = new MetroFramework.Controls.MetroLabel();
            monthComboBox = new MetroFramework.Controls.MetroComboBox();
            yearComboBox = new MetroFramework.Controls.MetroComboBox();
            metroLabel10 = new MetroFramework.Controls.MetroLabel();
            cardTypeView = new MetroFramework.Controls.MetroLabel();
            metroLabel12 = new MetroFramework.Controls.MetroLabel();
            foodBillLabel = new MetroFramework.Controls.MetroLabel();
            foodBillAmount = new MetroFramework.Controls.MetroLabel();
            phoneComboBox = new TextBox();
            cvc = new TextBox();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Location = new Point(453, 374);
            nextButton.Margin = new Padding(4, 5, 4, 5);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(117, 52);
            nextButton.TabIndex = 0;
            nextButton.Text = "Next";
            nextButton.UseSelectable = true;
            nextButton.Click += nextButton_Click;
            // 
            // reservation
            // 
            reservation.AutoSize = true;
            reservation.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            reservation.Location = new Point(19, 38);
            reservation.Margin = new Padding(4, 0, 4, 0);
            reservation.Name = "reservation";
            reservation.Size = new Size(86, 20);
            reservation.TabIndex = 1;
            reservation.Text = "Reservation";
            // 
            // currentBillAmount
            // 
            currentBillAmount.AutoSize = true;
            currentBillAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            currentBillAmount.Location = new Point(475, 74);
            currentBillAmount.Margin = new Padding(4, 0, 4, 0);
            currentBillAmount.Name = "currentBillAmount";
            currentBillAmount.Size = new Size(17, 20);
            currentBillAmount.TabIndex = 2;
            currentBillAmount.Text = "$";
            currentBillAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            priceLabel.Location = new Point(520, 38);
            priceLabel.Margin = new Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price";
            // 
            // currentBill
            // 
            currentBill.AutoSize = true;
            currentBill.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            currentBill.Location = new Point(19, 74);
            currentBill.Margin = new Padding(4, 0, 4, 0);
            currentBill.Name = "currentBill";
            currentBill.Size = new Size(82, 20);
            currentBill.TabIndex = 4;
            currentBill.Text = "Current bill";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.BackColor = Color.Transparent;
            paymentLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            paymentLabel.Location = new Point(19, 211);
            paymentLabel.Margin = new Padding(4, 0, 4, 0);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(65, 20);
            paymentLabel.TabIndex = 25;
            paymentLabel.Text = "Payment";
            paymentLabel.UseCustomBackColor = true;
            paymentLabel.UseCustomForeColor = true;
            // 
            // paymentComboBox
            // 
            paymentComboBox.FormattingEnabled = true;
            paymentComboBox.ItemHeight = 24;
            paymentComboBox.Items.AddRange(new object[] { "Credit", "Debit" });
            paymentComboBox.Location = new Point(24, 245);
            paymentComboBox.Margin = new Padding(4, 5, 4, 5);
            paymentComboBox.Name = "paymentComboBox";
            paymentComboBox.PromptText = "Payment type";
            paymentComboBox.Size = new Size(169, 30);
            paymentComboBox.TabIndex = 29;
            paymentComboBox.UseSelectable = true;
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel5.Location = new Point(356, 152);
            metroLabel5.Margin = new Padding(4, 0, 4, 0);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(30, 20);
            metroLabel5.TabIndex = 30;
            metroLabel5.Text = "Tax";
            // 
            // taxAmount
            // 
            taxAmount.AutoSize = true;
            taxAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            taxAmount.Location = new Point(457, 152);
            taxAmount.Margin = new Padding(4, 0, 4, 0);
            taxAmount.Name = "taxAmount";
            taxAmount.Size = new Size(17, 20);
            taxAmount.TabIndex = 31;
            taxAmount.Text = "$";
            taxAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            totalLabel.Location = new Point(327, 195);
            totalLabel.Margin = new Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(44, 20);
            totalLabel.TabIndex = 32;
            totalLabel.Text = "Total";
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            totalAmount.Location = new Point(445, 195);
            totalAmount.Margin = new Padding(4, 0, 4, 0);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(17, 20);
            totalAmount.TabIndex = 33;
            totalAmount.Text = "$";
            totalAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.ItemHeight = 24;
            monthComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            monthComboBox.Location = new Point(24, 308);
            monthComboBox.Margin = new Padding(4, 5, 4, 5);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.PromptText = "MM";
            monthComboBox.Size = new Size(77, 30);
            monthComboBox.TabIndex = 34;
            monthComboBox.UseSelectable = true;
            monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.ItemHeight = 24;
            yearComboBox.Items.AddRange(new object[] { "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            yearComboBox.Location = new Point(135, 309);
            yearComboBox.Margin = new Padding(4, 5, 4, 5);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.PromptText = "YY";
            yearComboBox.Size = new Size(59, 30);
            yearComboBox.TabIndex = 35;
            yearComboBox.UseSelectable = true;
            // 
            // metroLabel10
            // 
            metroLabel10.AutoSize = true;
            metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel10.Location = new Point(111, 315);
            metroLabel10.Margin = new Padding(4, 0, 4, 0);
            metroLabel10.Name = "metroLabel10";
            metroLabel10.Size = new Size(15, 20);
            metroLabel10.TabIndex = 36;
            metroLabel10.Text = "/";
            // 
            // cardTypeView
            // 
            cardTypeView.AutoSize = true;
            cardTypeView.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            cardTypeView.Location = new Point(395, 320);
            cardTypeView.Margin = new Padding(4, 0, 4, 0);
            cardTypeView.Name = "cardTypeView";
            cardTypeView.Size = new Size(70, 20);
            cardTypeView.TabIndex = 38;
            cardTypeView.Text = "Unknown";
            // 
            // metroLabel12
            // 
            metroLabel12.AutoSize = true;
            metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel12.Location = new Point(287, 318);
            metroLabel12.Margin = new Padding(4, 0, 4, 0);
            metroLabel12.Name = "metroLabel12";
            metroLabel12.Size = new Size(80, 20);
            metroLabel12.TabIndex = 39;
            metroLabel12.Text = "Card type :";
            // 
            // foodBillLabel
            // 
            foodBillLabel.AutoSize = true;
            foodBillLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            foodBillLabel.Location = new Point(19, 111);
            foodBillLabel.Margin = new Padding(4, 0, 4, 0);
            foodBillLabel.Name = "foodBillLabel";
            foodBillLabel.Size = new Size(68, 20);
            foodBillLabel.TabIndex = 40;
            foodBillLabel.Text = "Food bill";
            // 
            // foodBillAmount
            // 
            foodBillAmount.AutoSize = true;
            foodBillAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            foodBillAmount.Location = new Point(475, 111);
            foodBillAmount.Margin = new Padding(4, 0, 4, 0);
            foodBillAmount.Name = "foodBillAmount";
            foodBillAmount.Size = new Size(17, 20);
            foodBillAmount.TabIndex = 41;
            foodBillAmount.Text = "$";
            foodBillAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // phoneComboBox
            // 
            phoneComboBox.Location = new Point(279, 245);
            phoneComboBox.Name = "phoneComboBox";
            phoneComboBox.Size = new Size(213, 27);
            phoneComboBox.TabIndex = 42;
            // 
            // cvc
            // 
            cvc.Location = new Point(212, 311);
            cvc.Name = "cvc";
            cvc.Size = new Size(58, 27);
            cvc.TabIndex = 43;
            // 
            // FinalizePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            ClientSize = new Size(579, 437);
            Controls.Add(cvc);
            Controls.Add(phoneComboBox);
            Controls.Add(foodBillAmount);
            Controls.Add(foodBillLabel);
            Controls.Add(metroLabel12);
            Controls.Add(cardTypeView);
            Controls.Add(metroLabel10);
            Controls.Add(yearComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(totalAmount);
            Controls.Add(totalLabel);
            Controls.Add(taxAmount);
            Controls.Add(metroLabel5);
            Controls.Add(currentBill);
            Controls.Add(paymentComboBox);
            Controls.Add(priceLabel);
            Controls.Add(currentBillAmount);
            Controls.Add(reservation);
            Controls.Add(paymentLabel);
            Controls.Add(nextButton);
            DisplayHeader = false;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FinalizePayment";
            Padding = new Padding(27, 46, 27, 31);
            Resizable = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Style = MetroFramework.MetroColorStyle.Green;
            Load += FinalizePayment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroButton nextButton;
        private MetroFramework.Controls.MetroLabel reservation;
        private MetroFramework.Controls.MetroLabel currentBillAmount;
        private MetroFramework.Controls.MetroLabel priceLabel;
        private MetroFramework.Controls.MetroLabel currentBill;
        private MetroFramework.Controls.MetroLabel paymentLabel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel taxAmount;
        private MetroFramework.Controls.MetroLabel totalLabel;
        private MetroFramework.Controls.MetroLabel totalAmount;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel cardTypeView;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        public MetroFramework.Controls.MetroTextBox phoneNComboBox;
        public MetroFramework.Controls.MetroComboBox paymentComboBox;
        public MetroFramework.Controls.MetroComboBox monthComboBox;
        public MetroFramework.Controls.MetroComboBox yearComboBox;
        public MetroFramework.Controls.MetroTextBox cvcComboBox;
        private MetroFramework.Controls.MetroLabel foodBillLabel;
        private MetroFramework.Controls.MetroLabel foodBillAmount;
        public TextBox phoneComboBox;
        public TextBox cvc;
    }
}