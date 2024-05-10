namespace Hotel_Manager
{
    partial class Frontend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frontend));
            resPanel = new MetroFramework.Controls.MetroTabControl();
            reservationPage = new MetroFramework.Controls.MetroTabPage();
            rightMPanel = new MetroFramework.Controls.MetroPanel();
            resEditButton = new MetroFramework.Controls.MetroComboBox();
            newButton = new MetroFramework.Controls.MetroButton();
            deleteButton = new MetroFramework.Controls.MetroButton();
            editButton = new MetroFramework.Controls.MetroButton();
            updateButton = new MetroFramework.Controls.MetroButton();
            middlePanel = new MetroFramework.Controls.MetroPanel();
            smsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            foodSupplyCheckBox = new MetroFramework.Controls.MetroCheckBox();
            checkinCheckBox = new MetroFramework.Controls.MetroCheckBox();
            foodMenuButton = new MetroFramework.Controls.MetroButton();
            qtGuestComboBox = new MetroFramework.Controls.MetroComboBox();
            finalizeButton = new MetroFramework.Controls.MetroButton();
            metroLabel12 = new MetroFramework.Controls.MetroLabel();
            submitButton = new MetroFramework.Controls.MetroButton();
            depDatePicker = new DateTimePicker();
            roomNComboBox = new MetroFramework.Controls.MetroComboBox();
            floorComboBox = new MetroFramework.Controls.MetroComboBox();
            entryDatePicker = new DateTimePicker();
            entryLabel = new MetroFramework.Controls.MetroLabel();
            roomTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            choiceLabel = new MetroFramework.Controls.MetroLabel();
            leftMPanel = new MetroFramework.Controls.MetroPanel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            lNametextBox = new TextBox();
            dateTimePickerBirthdate = new DateTimePicker();
            cityLabel = new MetroFramework.Controls.MetroLabel();
            textBoxCity = new TextBox();
            textBoxAddress = new TextBox();
            textBoxEmail = new TextBox();
            phoneTextBox = new TextBox();
            fnameTextBox = new TextBox();
            emailLabel = new MetroFramework.Controls.MetroLabel();
            nameLabel = new MetroFramework.Controls.MetroLabel();
            genderComboBox = new MetroFramework.Controls.MetroComboBox();
            birthdayLabel = new MetroFramework.Controls.MetroLabel();
            phoneNumberLabel = new MetroFramework.Controls.MetroLabel();
            genderLabel = new MetroFramework.Controls.MetroLabel();
            stateComboBox = new MetroFramework.Controls.MetroComboBox();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            searchPage = new MetroFramework.Controls.MetroTabPage();
            SearchError = new MetroFramework.Controls.MetroLabel();
            searchDataGridView = new DataGridView();
            searchButton = new MetroFramework.Controls.MetroButton();
            searchTextBox = new TextBox();
            metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            resTotalDataGridView = new DataGridView();
            roomPage = new MetroFramework.Controls.MetroTabPage();
            metroLabel13 = new MetroFramework.Controls.MetroLabel();
            metroLabel11 = new MetroFramework.Controls.MetroLabel();
            reservedLabel = new MetroFramework.Controls.MetroLabel();
            roomReservedListBox = new ListBox();
            roomOccupiedListBox = new ListBox();
            occupiedLabel = new MetroFramework.Controls.MetroLabel();
            resPanel.SuspendLayout();
            reservationPage.SuspendLayout();
            rightMPanel.SuspendLayout();
            middlePanel.SuspendLayout();
            leftMPanel.SuspendLayout();
            searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).BeginInit();
            roomPage.SuspendLayout();
            SuspendLayout();
            // 
            // resPanel
            // 
            resPanel.Controls.Add(reservationPage);
            resPanel.Controls.Add(searchPage);
            resPanel.Controls.Add(metroTabPage2);
            resPanel.Controls.Add(roomPage);
            resPanel.Location = new Point(10, 73);
            resPanel.Margin = new Padding(4, 4, 4, 4);
            resPanel.Name = "resPanel";
            resPanel.Padding = new Point(10, 8);
            resPanel.SelectedIndex = 0;
            resPanel.Size = new Size(1148, 556);
            resPanel.Style = MetroFramework.MetroColorStyle.Green;
            resPanel.TabIndex = 0;
            resPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            resPanel.UseSelectable = true;
            // 
            // reservationPage
            // 
            reservationPage.Controls.Add(rightMPanel);
            reservationPage.Controls.Add(middlePanel);
            reservationPage.Controls.Add(leftMPanel);
            reservationPage.HorizontalScrollbarBarColor = true;
            reservationPage.HorizontalScrollbarHighlightOnWheel = false;
            reservationPage.HorizontalScrollbarSize = 11;
            reservationPage.Location = new Point(4, 38);
            reservationPage.Margin = new Padding(4, 4, 4, 4);
            reservationPage.Name = "reservationPage";
            reservationPage.Size = new Size(1140, 514);
            reservationPage.Style = MetroFramework.MetroColorStyle.Green;
            reservationPage.TabIndex = 0;
            reservationPage.Text = "Reservation";
            reservationPage.Theme = MetroFramework.MetroThemeStyle.Light;
            reservationPage.VerticalScrollbarBarColor = true;
            reservationPage.VerticalScrollbarHighlightOnWheel = false;
            reservationPage.VerticalScrollbarSize = 11;
            // 
            // rightMPanel
            // 
            rightMPanel.BackColor = Color.FromArgb(225, 225, 225);
            rightMPanel.BackgroundImageLayout = ImageLayout.None;
            rightMPanel.Controls.Add(resEditButton);
            rightMPanel.Controls.Add(newButton);
            rightMPanel.Controls.Add(deleteButton);
            rightMPanel.Controls.Add(editButton);
            rightMPanel.Controls.Add(updateButton);
            rightMPanel.HorizontalScrollbarBarColor = true;
            rightMPanel.HorizontalScrollbarHighlightOnWheel = false;
            rightMPanel.HorizontalScrollbarSize = 11;
            rightMPanel.Location = new Point(826, 16);
            rightMPanel.Margin = new Padding(4, 4, 4, 4);
            rightMPanel.Name = "rightMPanel";
            rightMPanel.Size = new Size(309, 486);
            rightMPanel.TabIndex = 34;
            rightMPanel.UseCustomBackColor = true;
            rightMPanel.UseCustomForeColor = true;
            rightMPanel.UseStyleColors = true;
            rightMPanel.VerticalScrollbarBarColor = true;
            rightMPanel.VerticalScrollbarHighlightOnWheel = false;
            rightMPanel.VerticalScrollbarSize = 11;
            // 
            // resEditButton
            // 
            resEditButton.FlatStyle = FlatStyle.Popup;
            resEditButton.ForeColor = Color.Green;
            resEditButton.FormattingEnabled = true;
            resEditButton.ItemHeight = 23;
            resEditButton.Items.AddRange(new object[] { "[ID]    [NAME]    [PHONE NUMBER]" });
            resEditButton.Location = new Point(11, 34);
            resEditButton.Margin = new Padding(4, 4, 4, 4);
            resEditButton.Name = "resEditButton";
            resEditButton.PromptText = "Select reservation to edit";
            resEditButton.Size = new Size(294, 29);
            resEditButton.TabIndex = 20;
            resEditButton.UseCustomForeColor = true;
            resEditButton.UseSelectable = true;
            resEditButton.UseStyleColors = true;
            resEditButton.Visible = false;
            resEditButton.SelectedIndexChanged += resEditButton_SelectedIndexChanged;
            // 
            // newButton
            // 
            newButton.Location = new Point(11, 434);
            newButton.Margin = new Padding(4, 4, 4, 4);
            newButton.Name = "newButton";
            newButton.Size = new Size(286, 37);
            newButton.Style = MetroFramework.MetroColorStyle.Green;
            newButton.TabIndex = 22;
            newButton.Text = "New reservation";
            newButton.UseSelectable = true;
            newButton.UseStyleColors = true;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Highlight = true;
            deleteButton.Location = new Point(11, 332);
            deleteButton.Margin = new Padding(4, 4, 4, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(286, 39);
            deleteButton.Style = MetroFramework.MetroColorStyle.Red;
            deleteButton.TabIndex = 23;
            deleteButton.Text = "Delete";
            deleteButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            deleteButton.UseSelectable = true;
            deleteButton.UseStyleColors = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(11, 386);
            editButton.Margin = new Padding(4, 4, 4, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(286, 37);
            editButton.Style = MetroFramework.MetroColorStyle.Green;
            editButton.TabIndex = 18;
            editButton.Text = "Edit existing Reservation";
            editButton.UseSelectable = true;
            editButton.UseStyleColors = true;
            editButton.Click += editButton_Click;
            // 
            // updateButton
            // 
            updateButton.Enabled = false;
            updateButton.Highlight = true;
            updateButton.Location = new Point(11, 284);
            updateButton.Margin = new Padding(4, 4, 4, 4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(286, 39);
            updateButton.Style = MetroFramework.MetroColorStyle.Green;
            updateButton.TabIndex = 19;
            updateButton.Text = "Update";
            updateButton.Theme = MetroFramework.MetroThemeStyle.Light;
            updateButton.UseSelectable = true;
            updateButton.UseStyleColors = true;
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // middlePanel
            // 
            middlePanel.BackColor = Color.FromArgb(225, 225, 225);
            middlePanel.BackgroundImageLayout = ImageLayout.None;
            middlePanel.Controls.Add(smsCheckBox);
            middlePanel.Controls.Add(foodSupplyCheckBox);
            middlePanel.Controls.Add(checkinCheckBox);
            middlePanel.Controls.Add(foodMenuButton);
            middlePanel.Controls.Add(qtGuestComboBox);
            middlePanel.Controls.Add(finalizeButton);
            middlePanel.Controls.Add(metroLabel12);
            middlePanel.Controls.Add(submitButton);
            middlePanel.Controls.Add(depDatePicker);
            middlePanel.Controls.Add(roomNComboBox);
            middlePanel.Controls.Add(floorComboBox);
            middlePanel.Controls.Add(entryDatePicker);
            middlePanel.Controls.Add(entryLabel);
            middlePanel.Controls.Add(roomTypeComboBox);
            middlePanel.Controls.Add(choiceLabel);
            middlePanel.HorizontalScrollbarBarColor = true;
            middlePanel.HorizontalScrollbarHighlightOnWheel = false;
            middlePanel.HorizontalScrollbarSize = 11;
            middlePanel.Location = new Point(413, 16);
            middlePanel.Margin = new Padding(4, 4, 4, 4);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(402, 486);
            middlePanel.TabIndex = 16;
            middlePanel.UseCustomBackColor = true;
            middlePanel.UseCustomForeColor = true;
            middlePanel.UseStyleColors = true;
            middlePanel.VerticalScrollbarBarColor = true;
            middlePanel.VerticalScrollbarHighlightOnWheel = false;
            middlePanel.VerticalScrollbarSize = 11;
            // 
            // smsCheckBox
            // 
            smsCheckBox.AutoSize = true;
            smsCheckBox.BackColor = Color.Transparent;
            smsCheckBox.Location = new Point(122, 336);
            smsCheckBox.Margin = new Padding(4, 4, 4, 4);
            smsCheckBox.Name = "smsCheckBox";
            smsCheckBox.Size = new Size(78, 15);
            smsCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            smsCheckBox.TabIndex = 35;
            smsCheckBox.Text = "Send sms?";
            smsCheckBox.UseCustomBackColor = true;
            smsCheckBox.UseSelectable = true;
            smsCheckBox.UseVisualStyleBackColor = false;
            // 
            // foodSupplyCheckBox
            // 
            foodSupplyCheckBox.AutoSize = true;
            foodSupplyCheckBox.BackColor = Color.Transparent;
            foodSupplyCheckBox.Location = new Point(227, 334);
            foodSupplyCheckBox.Margin = new Padding(4, 4, 4, 4);
            foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            foodSupplyCheckBox.Size = new Size(133, 15);
            foodSupplyCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            foodSupplyCheckBox.TabIndex = 34;
            foodSupplyCheckBox.Text = "Food/Supply status ?";
            foodSupplyCheckBox.UseCustomBackColor = true;
            foodSupplyCheckBox.UseSelectable = true;
            foodSupplyCheckBox.UseVisualStyleBackColor = false;
            foodSupplyCheckBox.CheckedChanged += foodSupplyCheckBox_CheckedChanged;
            // 
            // checkinCheckBox
            // 
            checkinCheckBox.AutoSize = true;
            checkinCheckBox.BackColor = Color.Transparent;
            checkinCheckBox.Location = new Point(18, 336);
            checkinCheckBox.Margin = new Padding(4, 4, 4, 4);
            checkinCheckBox.Name = "checkinCheckBox";
            checkinCheckBox.Size = new Size(77, 15);
            checkinCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            checkinCheckBox.TabIndex = 33;
            checkinCheckBox.Text = "Check in ?";
            checkinCheckBox.UseCustomBackColor = true;
            checkinCheckBox.UseSelectable = true;
            checkinCheckBox.UseVisualStyleBackColor = false;
            checkinCheckBox.CheckedChanged += checkinCheckBox_CheckedChanged;
            // 
            // foodMenuButton
            // 
            foodMenuButton.Location = new Point(18, 280);
            foodMenuButton.Margin = new Padding(4, 4, 4, 4);
            foodMenuButton.Name = "foodMenuButton";
            foodMenuButton.Size = new Size(367, 39);
            foodMenuButton.Style = MetroFramework.MetroColorStyle.Green;
            foodMenuButton.TabIndex = 23;
            foodMenuButton.Text = "Food and menu";
            foodMenuButton.UseSelectable = true;
            foodMenuButton.UseStyleColors = true;
            foodMenuButton.Click += foodMenuButton_Click;
            // 
            // qtGuestComboBox
            // 
            qtGuestComboBox.FormattingEnabled = true;
            qtGuestComboBox.ItemHeight = 23;
            qtGuestComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            qtGuestComboBox.Location = new Point(18, 34);
            qtGuestComboBox.Margin = new Padding(4, 4, 4, 4);
            qtGuestComboBox.Name = "qtGuestComboBox";
            qtGuestComboBox.PromptText = "# of guests";
            qtGuestComboBox.Size = new Size(176, 29);
            qtGuestComboBox.TabIndex = 25;
            qtGuestComboBox.UseSelectable = true;
            // 
            // finalizeButton
            // 
            finalizeButton.Location = new Point(18, 389);
            finalizeButton.Margin = new Padding(4, 4, 4, 4);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new Size(367, 36);
            finalizeButton.Style = MetroFramework.MetroColorStyle.Green;
            finalizeButton.TabIndex = 22;
            finalizeButton.Text = "Finalize bill";
            finalizeButton.UseSelectable = true;
            finalizeButton.UseStyleColors = true;
            finalizeButton.Click += finalizeButton_Click;
            // 
            // metroLabel12
            // 
            metroLabel12.AutoSize = true;
            metroLabel12.BackColor = Color.Transparent;
            metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel12.Location = new Point(18, 195);
            metroLabel12.Margin = new Padding(4, 0, 4, 0);
            metroLabel12.Name = "metroLabel12";
            metroLabel12.Size = new Size(110, 19);
            metroLabel12.TabIndex = 32;
            metroLabel12.Text = "Deperture [date]";
            metroLabel12.UseCustomBackColor = true;
            metroLabel12.UseCustomForeColor = true;
            // 
            // submitButton
            // 
            submitButton.Highlight = true;
            submitButton.Location = new Point(18, 429);
            submitButton.Margin = new Padding(4, 4, 4, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(367, 41);
            submitButton.Style = MetroFramework.MetroColorStyle.Green;
            submitButton.TabIndex = 17;
            submitButton.Text = "Submit";
            submitButton.Theme = MetroFramework.MetroThemeStyle.Light;
            submitButton.UseSelectable = true;
            submitButton.UseStyleColors = true;
            submitButton.Visible = false;
            submitButton.Click += submitButton_Click;
            // 
            // depDatePicker
            // 
            depDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            depDatePicker.Format = DateTimePickerFormat.Custom;
            depDatePicker.Location = new Point(18, 220);
            depDatePicker.Margin = new Padding(4, 4, 4, 4);
            depDatePicker.MaxDate = new DateTime(2025, 4, 27, 23, 59, 0, 0);
            depDatePicker.MinDate = new DateTime(2014, 4, 27, 0, 0, 0, 0);
            depDatePicker.Name = "depDatePicker";
            depDatePicker.Size = new Size(368, 26);
            depDatePicker.TabIndex = 31;
            depDatePicker.Value = new DateTime(2014, 4, 27, 0, 0, 0, 0);
            // 
            // roomNComboBox
            // 
            roomNComboBox.FormattingEnabled = true;
            roomNComboBox.ItemHeight = 23;
            roomNComboBox.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510" });
            roomNComboBox.Location = new Point(202, 96);
            roomNComboBox.Margin = new Padding(4, 4, 4, 4);
            roomNComboBox.Name = "roomNComboBox";
            roomNComboBox.PromptText = "#";
            roomNComboBox.Size = new Size(185, 29);
            roomNComboBox.TabIndex = 24;
            roomNComboBox.UseSelectable = true;
            // 
            // floorComboBox
            // 
            floorComboBox.FormattingEnabled = true;
            floorComboBox.ItemHeight = 23;
            floorComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            floorComboBox.Location = new Point(18, 96);
            floorComboBox.Margin = new Padding(4, 4, 4, 4);
            floorComboBox.Name = "floorComboBox";
            floorComboBox.PromptText = "Floor";
            floorComboBox.Size = new Size(176, 29);
            floorComboBox.TabIndex = 23;
            floorComboBox.UseSelectable = true;
            // 
            // entryDatePicker
            // 
            entryDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryDatePicker.Format = DateTimePickerFormat.Custom;
            entryDatePicker.Location = new Point(18, 161);
            entryDatePicker.Margin = new Padding(4, 4, 4, 4);
            entryDatePicker.MaxDate = new DateTime(2025, 4, 27, 23, 59, 0, 0);
            entryDatePicker.MinDate = new DateTime(2014, 5, 11, 0, 0, 0, 0);
            entryDatePicker.Name = "entryDatePicker";
            entryDatePicker.Size = new Size(365, 26);
            entryDatePicker.TabIndex = 26;
            entryDatePicker.Value = new DateTime(2014, 5, 11, 0, 0, 0, 0);
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.BackColor = Color.Transparent;
            entryLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            entryLabel.Location = new Point(18, 136);
            entryLabel.Margin = new Padding(4, 0, 4, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(80, 19);
            entryLabel.TabIndex = 30;
            entryLabel.Text = "Entry [date]";
            entryLabel.UseCustomBackColor = true;
            entryLabel.UseCustomForeColor = true;
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.ItemHeight = 23;
            roomTypeComboBox.Items.AddRange(new object[] { "Single", "Double", "Twin", "Duplex", "Suite" });
            roomTypeComboBox.Location = new Point(202, 34);
            roomTypeComboBox.Margin = new Padding(4, 4, 4, 4);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.PromptText = "Room type";
            roomTypeComboBox.Size = new Size(185, 29);
            roomTypeComboBox.TabIndex = 22;
            roomTypeComboBox.UseSelectable = true;
            roomTypeComboBox.SelectedIndexChanged += roomTypeComboBox_SelectedIndexChanged;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.BackColor = Color.Transparent;
            choiceLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            choiceLabel.Location = new Point(18, 9);
            choiceLabel.Margin = new Padding(4, 0, 4, 0);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(85, 19);
            choiceLabel.TabIndex = 21;
            choiceLabel.Text = "Your choices";
            choiceLabel.UseCustomBackColor = true;
            choiceLabel.UseCustomForeColor = true;
            // 
            // leftMPanel
            // 
            leftMPanel.BackColor = Color.FromArgb(225, 225, 225);
            leftMPanel.BackgroundImageLayout = ImageLayout.None;
            leftMPanel.Controls.Add(metroLabel1);
            leftMPanel.Controls.Add(lNametextBox);
            leftMPanel.Controls.Add(dateTimePickerBirthdate);
            leftMPanel.Controls.Add(cityLabel);
            leftMPanel.Controls.Add(textBoxCity);
            leftMPanel.Controls.Add(textBoxAddress);
            leftMPanel.Controls.Add(textBoxEmail);
            leftMPanel.Controls.Add(phoneTextBox);
            leftMPanel.Controls.Add(fnameTextBox);
            leftMPanel.Controls.Add(emailLabel);
            leftMPanel.Controls.Add(nameLabel);
            leftMPanel.Controls.Add(genderComboBox);
            leftMPanel.Controls.Add(birthdayLabel);
            leftMPanel.Controls.Add(phoneNumberLabel);
            leftMPanel.Controls.Add(genderLabel);
            leftMPanel.Controls.Add(stateComboBox);
            leftMPanel.Controls.Add(metroLabel6);
            leftMPanel.HorizontalScrollbarBarColor = true;
            leftMPanel.HorizontalScrollbarHighlightOnWheel = false;
            leftMPanel.HorizontalScrollbarSize = 11;
            leftMPanel.Location = new Point(4, 16);
            leftMPanel.Margin = new Padding(4, 4, 4, 4);
            leftMPanel.Name = "leftMPanel";
            leftMPanel.Size = new Size(402, 486);
            leftMPanel.TabIndex = 4;
            leftMPanel.UseCustomBackColor = true;
            leftMPanel.UseCustomForeColor = true;
            leftMPanel.UseStyleColors = true;
            leftMPanel.VerticalScrollbarBarColor = true;
            leftMPanel.VerticalScrollbarHighlightOnWheel = false;
            leftMPanel.VerticalScrollbarSize = 11;
            //leftMPanel.Paint += leftMPanel_Paint;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.BackColor = Color.Transparent;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel1.Location = new Point(237, 8);
            metroLabel1.Margin = new Padding(4, 0, 4, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(72, 19);
            metroLabel1.TabIndex = 29;
            metroLabel1.Text = "Last name";
            metroLabel1.UseCustomBackColor = true;
            metroLabel1.UseCustomForeColor = true;
            // 
            // lNametextBox
            // 
            lNametextBox.Location = new Point(236, 36);
            lNametextBox.Margin = new Padding(3, 2, 3, 2);
            lNametextBox.Name = "lNametextBox";
            lNametextBox.Size = new Size(110, 23);
            lNametextBox.TabIndex = 28;
            // 
            // dateTimePickerBirthdate
            // 
            dateTimePickerBirthdate.Location = new Point(69, 98);
            dateTimePickerBirthdate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            dateTimePickerBirthdate.Size = new Size(219, 23);
            dateTimePickerBirthdate.TabIndex = 27;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = Color.Transparent;
            cityLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            cityLabel.Location = new Point(18, 332);
            cityLabel.Margin = new Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(33, 19);
            cityLabel.TabIndex = 25;
            cityLabel.Text = "City";
            cityLabel.UseCustomBackColor = true;
            cityLabel.UseCustomForeColor = true;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(164, 326);
            textBoxCity.Margin = new Padding(3, 2, 3, 2);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(110, 23);
            textBoxCity.TabIndex = 24;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(164, 285);
            textBoxAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(110, 23);
            textBoxAddress.TabIndex = 23;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(164, 254);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(110, 23);
            textBoxEmail.TabIndex = 22;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(18, 222);
            phoneTextBox.Margin = new Padding(3, 2, 3, 2);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(110, 23);
            phoneTextBox.TabIndex = 21;
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(18, 34);
            fnameTextBox.Margin = new Padding(3, 2, 3, 2);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(110, 23);
            fnameTextBox.TabIndex = 20;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            emailLabel.Location = new Point(18, 260);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(130, 19);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Your e-mail address";
            emailLabel.UseCustomBackColor = true;
            emailLabel.UseCustomForeColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            nameLabel.Location = new Point(17, 8);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(73, 19);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "First name";
            nameLabel.UseCustomBackColor = true;
            nameLabel.UseCustomForeColor = true;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.ItemHeight = 23;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            genderComboBox.Location = new Point(18, 161);
            genderComboBox.Margin = new Padding(4, 4, 4, 4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.PromptText = "........";
            genderComboBox.Size = new Size(367, 29);
            genderComboBox.TabIndex = 11;
            genderComboBox.UseSelectable = true;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = Color.Transparent;
            birthdayLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            birthdayLabel.Location = new Point(14, 74);
            birthdayLabel.Margin = new Padding(4, 0, 4, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(60, 19);
            birthdayLabel.TabIndex = 5;
            birthdayLabel.Text = "Birthday";
            birthdayLabel.UseCustomBackColor = true;
            birthdayLabel.UseCustomForeColor = true;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = Color.Transparent;
            phoneNumberLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            phoneNumberLabel.Location = new Point(17, 196);
            phoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(100, 19);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone number";
            phoneNumberLabel.UseCustomBackColor = true;
            phoneNumberLabel.UseCustomForeColor = true;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.Transparent;
            genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            genderLabel.Location = new Point(15, 136);
            genderLabel.Margin = new Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(54, 19);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender";
            genderLabel.UseCustomBackColor = true;
            genderLabel.UseCustomForeColor = true;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.ItemHeight = 23;
            stateComboBox.Items.AddRange(new object[] { "Alabama ", "Alaska ", "Arizona ", "Arkansas ", "California ", "Colorado ", "Connecticut ", "Delaware ", "Florida ", "Georgia ", "Hawaii ", "Idaho ", "Illinois Indiana ", "Iowa ", "Kansas ", "Kentucky ", "Louisiana ", "Maine ", "Maryland ", "Massachusetts ", "Michigan ", "Minnesota ", "Mississippi ", "Missouri ", "Montana Nebraska ", "Nevada ", "New Hampshire ", "New Jersey ", "New Mexico ", "New York ", "North Carolina ", "North Dakota ", "Ohio ", "Oklahoma ", "Oregon ", "Pennsylvania Rhode Island ", "South Carolina ", "South Dakota ", "Tennessee ", "Texas ", "Utah ", "Vermont ", "Virginia ", "Washington ", "West Virginia ", "Wisconsin ", "Wyoming" });
            stateComboBox.Location = new Point(86, 402);
            stateComboBox.Margin = new Padding(4, 4, 4, 4);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.PromptText = "State";
            stateComboBox.Size = new Size(175, 29);
            stateComboBox.TabIndex = 19;
            stateComboBox.UseSelectable = true;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.BackColor = Color.Transparent;
            metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel6.Location = new Point(17, 285);
            metroLabel6.Margin = new Padding(4, 0, 4, 0);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(88, 19);
            metroLabel6.TabIndex = 16;
            metroLabel6.Text = "Your address";
            metroLabel6.UseCustomBackColor = true;
            metroLabel6.UseCustomForeColor = true;
            // 
            // searchPage
            // 
            searchPage.Controls.Add(SearchError);
            searchPage.Controls.Add(searchDataGridView);
            searchPage.Controls.Add(searchButton);
            searchPage.Controls.Add(searchTextBox);
            searchPage.HorizontalScrollbarBarColor = true;
            searchPage.HorizontalScrollbarHighlightOnWheel = false;
            searchPage.HorizontalScrollbarSize = 11;
            searchPage.Location = new Point(4, 38);
            searchPage.Margin = new Padding(4, 4, 4, 4);
            searchPage.Name = "searchPage";
            searchPage.Size = new Size(1140, 514);
            searchPage.TabIndex = 4;
            searchPage.Text = "Universal Search";
            searchPage.VerticalScrollbarBarColor = true;
            searchPage.VerticalScrollbarHighlightOnWheel = false;
            searchPage.VerticalScrollbarSize = 11;
            // 
            // SearchError
            // 
            SearchError.AutoSize = true;
            SearchError.FontSize = MetroFramework.MetroLabelSize.Tall;
            SearchError.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            SearchError.Location = new Point(315, 44);
            SearchError.Margin = new Padding(4, 0, 4, 0);
            SearchError.Name = "SearchError";
            SearchError.Size = new Size(313, 150);
            SearchError.Style = MetroFramework.MetroColorStyle.Green;
            SearchError.TabIndex = 19;
            SearchError.Text = "I ran out of entries :( SORRY DUDE.\r\n\r\nYou know, we can make another deal. \r\n\r\nI sure will find something.\r\n";
            SearchError.Theme = MetroFramework.MetroThemeStyle.Light;
            SearchError.Visible = false;
            // 
            // searchDataGridView
            // 
            searchDataGridView.AllowUserToAddRows = false;
            searchDataGridView.AllowUserToDeleteRows = false;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new Point(80, 46);
            searchDataGridView.Margin = new Padding(4, 4, 4, 4);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.RowHeadersWidth = 51;
            searchDataGridView.Size = new Size(851, 272);
            searchDataGridView.TabIndex = 18;
            searchDataGridView.Visible = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BackgroundImage = (Image)resources.GetObject("searchButton.BackgroundImage");
            searchButton.BackgroundImageLayout = ImageLayout.Zoom;
            searchButton.Location = new Point(886, 226);
            searchButton.Margin = new Padding(4, 4, 4, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(53, 34);
            searchButton.TabIndex = 17;
            searchButton.UseCustomBackColor = true;
            searchButton.UseSelectable = true;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(435, 206);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(355, 23);
            searchTextBox.TabIndex = 35;
            // 
            // metroTabPage2
            // 
            metroTabPage2.AutoScroll = true;
            metroTabPage2.Controls.Add(resTotalDataGridView);
            metroTabPage2.HorizontalScrollbar = true;
            metroTabPage2.HorizontalScrollbarBarColor = true;
            metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            metroTabPage2.HorizontalScrollbarSize = 11;
            metroTabPage2.Location = new Point(4, 38);
            metroTabPage2.Margin = new Padding(4, 4, 4, 4);
            metroTabPage2.Name = "metroTabPage2";
            metroTabPage2.Size = new Size(1140, 514);
            metroTabPage2.TabIndex = 3;
            metroTabPage2.Text = "Reservation Adv. view";
            metroTabPage2.VerticalScrollbar = true;
            metroTabPage2.VerticalScrollbarBarColor = true;
            metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            metroTabPage2.VerticalScrollbarSize = 11;
            // 
            // resTotalDataGridView
            // 
            resTotalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resTotalDataGridView.Location = new Point(0, 4);
            resTotalDataGridView.Margin = new Padding(4, 4, 4, 4);
            resTotalDataGridView.Name = "resTotalDataGridView";
            resTotalDataGridView.RowHeadersWidth = 51;
            resTotalDataGridView.Size = new Size(1138, 501);
            resTotalDataGridView.TabIndex = 2;
            // 
            // roomPage
            // 
            roomPage.Controls.Add(metroLabel13);
            roomPage.Controls.Add(metroLabel11);
            roomPage.Controls.Add(reservedLabel);
            roomPage.Controls.Add(roomReservedListBox);
            roomPage.Controls.Add(roomOccupiedListBox);
            roomPage.Controls.Add(occupiedLabel);
            roomPage.HorizontalScrollbarBarColor = true;
            roomPage.HorizontalScrollbarHighlightOnWheel = false;
            roomPage.HorizontalScrollbarSize = 11;
            roomPage.Location = new Point(4, 38);
            roomPage.Margin = new Padding(4, 4, 4, 4);
            roomPage.Name = "roomPage";
            roomPage.Size = new Size(1140, 514);
            roomPage.TabIndex = 2;
            roomPage.Text = "Room availibility";
            roomPage.VerticalScrollbarBarColor = true;
            roomPage.VerticalScrollbarHighlightOnWheel = false;
            roomPage.VerticalScrollbarSize = 11;
            // 
            // metroLabel13
            // 
            metroLabel13.AutoSize = true;
            metroLabel13.BackColor = Color.Transparent;
            metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel13.Location = new Point(536, 32);
            metroLabel13.Margin = new Padding(4, 0, 4, 0);
            metroLabel13.Name = "metroLabel13";
            metroLabel13.Size = new Size(478, 19);
            metroLabel13.TabIndex = 10;
            metroLabel13.Text = "Room#| Type  |  ID#   |       Name      |      Phone #      |     Entry       |    Depart";
            metroLabel13.UseCustomBackColor = true;
            metroLabel13.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            metroLabel11.AutoSize = true;
            metroLabel11.BackColor = Color.Transparent;
            metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel11.Location = new Point(-4, 32);
            metroLabel11.Margin = new Padding(4, 0, 4, 0);
            metroLabel11.Name = "metroLabel11";
            metroLabel11.Size = new Size(310, 19);
            metroLabel11.TabIndex = 9;
            metroLabel11.Text = "Room#| Type  |  ID#   |       Name      |      Phone #";
            metroLabel11.UseCustomBackColor = true;
            metroLabel11.UseCustomForeColor = true;
            // 
            // reservedLabel
            // 
            reservedLabel.AutoSize = true;
            reservedLabel.BackColor = Color.Transparent;
            reservedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            reservedLabel.Location = new Point(536, 4);
            reservedLabel.Margin = new Padding(4, 0, 4, 0);
            reservedLabel.Name = "reservedLabel";
            reservedLabel.Size = new Size(64, 19);
            reservedLabel.TabIndex = 8;
            reservedLabel.Text = "Reserved";
            reservedLabel.UseCustomBackColor = true;
            reservedLabel.UseCustomForeColor = true;
            // 
            // roomReservedListBox
            // 
            roomReservedListBox.BackColor = Color.FromArgb(224, 224, 224);
            roomReservedListBox.FormattingEnabled = true;
            roomReservedListBox.HorizontalScrollbar = true;
            roomReservedListBox.IntegralHeight = false;
            roomReservedListBox.ItemHeight = 15;
            roomReservedListBox.Location = new Point(536, 58);
            roomReservedListBox.Margin = new Padding(4, 4, 4, 4);
            roomReservedListBox.Name = "roomReservedListBox";
            roomReservedListBox.Size = new Size(602, 447);
            roomReservedListBox.TabIndex = 7;
            // 
            // roomOccupiedListBox
            // 
            roomOccupiedListBox.BackColor = Color.FromArgb(224, 224, 224);
            roomOccupiedListBox.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomOccupiedListBox.FormattingEnabled = true;
            roomOccupiedListBox.HorizontalScrollbar = true;
            roomOccupiedListBox.IntegralHeight = false;
            roomOccupiedListBox.ItemHeight = 13;
            roomOccupiedListBox.Location = new Point(0, 58);
            roomOccupiedListBox.Margin = new Padding(4, 4, 4, 4);
            roomOccupiedListBox.Name = "roomOccupiedListBox";
            roomOccupiedListBox.Size = new Size(530, 447);
            roomOccupiedListBox.TabIndex = 6;
            // 
            // occupiedLabel
            // 
            occupiedLabel.AutoSize = true;
            occupiedLabel.BackColor = Color.Transparent;
            occupiedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            occupiedLabel.Location = new Point(-4, 4);
            occupiedLabel.Margin = new Padding(4, 0, 4, 0);
            occupiedLabel.Name = "occupiedLabel";
            occupiedLabel.Size = new Size(66, 19);
            occupiedLabel.TabIndex = 5;
            occupiedLabel.Text = "Occupied";
            occupiedLabel.UseCustomBackColor = true;
            occupiedLabel.UseCustomForeColor = true;
            // 
            // Frontend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackImage = (Image)resources.GetObject("$this.BackImage");
            BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            ClientSize = new Size(1165, 629);
            Controls.Add(resPanel);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Frontend";
            Padding = new Padding(24, 69, 24, 23);
            ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            StartPosition = FormStartPosition.Manual;
            Style = MetroFramework.MetroColorStyle.Green;
            Text = "Frontend";
            FormClosing += frontend_FormClosing;
            Load += MainTab_Load;
            resPanel.ResumeLayout(false);
            reservationPage.ResumeLayout(false);
            rightMPanel.ResumeLayout(false);
            middlePanel.ResumeLayout(false);
            middlePanel.PerformLayout();
            leftMPanel.ResumeLayout(false);
            leftMPanel.PerformLayout();
            searchPage.ResumeLayout(false);
            searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).EndInit();
            roomPage.ResumeLayout(false);
            roomPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion



        private MetroFramework.Controls.MetroTabControl resPanel;
        private MetroFramework.Controls.MetroTabPage reservationPage;
        private MetroFramework.Controls.MetroPanel leftMPanel;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroLabel birthdayLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox yearTextBox;
        private MetroFramework.Controls.MetroTextBox phoneNumberTextBox;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroLabel phoneNumberLabel;
        private MetroFramework.Controls.MetroComboBox genderComboBox;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroPanel middlePanel;
        private MetroFramework.Controls.MetroTextBox zipComboBox;
        private MetroFramework.Controls.MetroComboBox stateComboBox;
        private MetroFramework.Controls.MetroTextBox cityTextBox;
        private MetroFramework.Controls.MetroTextBox aptTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox addLabel;
        private MetroFramework.Controls.MetroComboBox roomTypeComboBox;
        private MetroFramework.Controls.MetroLabel choiceLabel;
        private MetroFramework.Controls.MetroComboBox roomNComboBox;
        private MetroFramework.Controls.MetroComboBox floorComboBox;
        private MetroFramework.Controls.MetroButton submitButton;

        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton finalizeButton;
        private MetroFramework.Controls.MetroButton newButton;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.DateTimePicker depDatePicker;
        private MetroFramework.Controls.MetroLabel entryLabel;
        private MetroFramework.Controls.MetroButton foodMenuButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroCheckBox checkinCheckBox;
        private MetroFramework.Controls.MetroComboBox resEditButton;
        private MetroFramework.Controls.MetroPanel rightMPanel;

        private MetroFramework.Controls.MetroTabPage roomPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
      
        private System.Windows.Forms.DataGridView resTotalDataGridView;
        private MetroFramework.Controls.MetroCheckBox foodSupplyCheckBox;
        private System.Windows.Forms.ListBox roomOccupiedListBox;
        private MetroFramework.Controls.MetroLabel occupiedLabel;
        private MetroFramework.Controls.MetroLabel reservedLabel;
        private System.Windows.Forms.ListBox roomReservedListBox;
        private MetroFramework.Controls.MetroTabPage searchPage;
        private TextBox searchTextBox;
        private MetroFramework.Controls.MetroComboBox qtGuestComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroLabel SearchError;
        private MetroFramework.Controls.MetroCheckBox smsCheckBox;
        private TextBox textBoxEmail;
        private TextBox phoneTextBox;
        private TextBox fnameTextBox;
        private TextBox textBoxAddress;
        private MetroFramework.Controls.MetroLabel cityLabel;
        private TextBox textBoxCity;
        private DateTimePicker dateTimePickerBirthdate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private TextBox lNametextBox;
    }
}