using System.Windows.Forms;

namespace Hotel_Manager
{
    partial class Kitchen
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TodoTabPage = new MetroFramework.Controls.MetroTabPage();
            this.onTheLineLabel = new MetroFramework.Controls.MetroLabel();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.roomNLabel = new MetroFramework.Controls.MetroLabel();
            this.floorNLabel = new MetroFramework.Controls.MetroLabel();
            this.roomTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.Todo = new System.Windows.Forms.GroupBox();
            this.dinnerQTLabel = new MetroFramework.Controls.MetroLabel();
            this.lunchQTLabel = new MetroFramework.Controls.MetroLabel();
            this.breakfastQTLabel = new MetroFramework.Controls.MetroLabel();
            this.breakfastTextBox = new TextBox();
            this.foodSelectionButton = new MetroFramework.Controls.MetroButton();
            this.supplyCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.lunchTextBox = new TextBox();
            this.towelCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.dinnerTextBox = new TextBox();
            this.cleaningCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.surpriseCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.floorNTextBox = new TextBox();
            this.roomNTextBox = new TextBox();
            this.roomTypeTextBox = new TextBox();
            this.phoneNTextBox = new TextBox();
            this.queueListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.phoneNLabel = new MetroFramework.Controls.MetroLabel();
            this.firstNameTextBox = new TextBox();
            this.lastNameTextBox = new TextBox();
            this.overviewTabPage = new MetroFramework.Controls.MetroTabPage();
            this.overviewDataGridView = new System.Windows.Forms.DataGridView();
            this.metroTabControl1.SuspendLayout();
            this.TodoTabPage.SuspendLayout();
            this.Todo.SuspendLayout();
            this.overviewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TodoTabPage);
            this.metroTabControl1.Controls.Add(this.overviewTabPage);
            this.metroTabControl1.Location = new System.Drawing.Point(15, 78);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1311, 591);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // TodoTabPage
            // 
            this.TodoTabPage.Controls.Add(this.onTheLineLabel);
            this.TodoTabPage.Controls.Add(this.updateButton);
            this.TodoTabPage.Controls.Add(this.roomNLabel);
            this.TodoTabPage.Controls.Add(this.floorNLabel);
            this.TodoTabPage.Controls.Add(this.roomTypeLabel);
            this.TodoTabPage.Controls.Add(this.Todo);
            this.TodoTabPage.Controls.Add(this.floorNTextBox);
            this.TodoTabPage.Controls.Add(this.roomNTextBox);
            this.TodoTabPage.Controls.Add(this.roomTypeTextBox);
            this.TodoTabPage.Controls.Add(this.phoneNTextBox);
            this.TodoTabPage.Controls.Add(this.queueListBox);
            this.TodoTabPage.Controls.Add(this.nameLabel);
            this.TodoTabPage.Controls.Add(this.phoneNLabel);
            this.TodoTabPage.Controls.Add(this.firstNameTextBox);
            this.TodoTabPage.Controls.Add(this.lastNameTextBox);
            this.TodoTabPage.HorizontalScrollbarBarColor = true;
            this.TodoTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.TodoTabPage.HorizontalScrollbarSize = 12;
            this.TodoTabPage.Location = new System.Drawing.Point(4, 38);
            this.TodoTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TodoTabPage.Name = "TodoTabPage";
            this.TodoTabPage.Size = new System.Drawing.Size(1303, 549);
            this.TodoTabPage.Style = MetroFramework.MetroColorStyle.Lime;
            this.TodoTabPage.TabIndex = 0;
            this.TodoTabPage.Text = "TODO*";
            this.TodoTabPage.VerticalScrollbarBarColor = true;
            this.TodoTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.TodoTabPage.VerticalScrollbarSize = 13;
            // 
            // onTheLineLabel
            // 
            this.onTheLineLabel.AutoSize = true;
            this.onTheLineLabel.BackColor = System.Drawing.Color.Transparent;
            this.onTheLineLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.onTheLineLabel.Location = new System.Drawing.Point(943, 37);
            this.onTheLineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.onTheLineLabel.Name = "onTheLineLabel";
            this.onTheLineLabel.Size = new System.Drawing.Size(81, 20);
            this.onTheLineLabel.TabIndex = 61;
            this.onTheLineLabel.Text = "On the line";
            this.onTheLineLabel.UseCustomBackColor = true;
            this.onTheLineLabel.UseCustomForeColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(943, 471);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(299, 38);
            this.updateButton.Style = MetroFramework.MetroColorStyle.Green;
            this.updateButton.TabIndex = 60;
            this.updateButton.Text = "Update changes";
            this.updateButton.UseSelectable = true;
            this.updateButton.UseStyleColors = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // roomNLabel
            // 
            this.roomNLabel.AutoSize = true;
            this.roomNLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomNLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.roomNLabel.Location = new System.Drawing.Point(39, 314);
            this.roomNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomNLabel.Name = "roomNLabel";
            this.roomNLabel.Size = new System.Drawing.Size(62, 20);
            this.roomNLabel.TabIndex = 58;
            this.roomNLabel.Text = "Room #";
            this.roomNLabel.UseCustomBackColor = true;
            this.roomNLabel.UseCustomForeColor = true;
            // 
            // floorNLabel
            // 
            this.floorNLabel.AutoSize = true;
            this.floorNLabel.BackColor = System.Drawing.Color.Transparent;
            this.floorNLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.floorNLabel.Location = new System.Drawing.Point(255, 238);
            this.floorNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.floorNLabel.Name = "floorNLabel";
            this.floorNLabel.Size = new System.Drawing.Size(56, 20);
            this.floorNLabel.TabIndex = 57;
            this.floorNLabel.Text = "Floor #";
            this.floorNLabel.UseCustomBackColor = true;
            this.floorNLabel.UseCustomForeColor = true;
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomTypeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.roomTypeLabel.Location = new System.Drawing.Point(39, 238);
            this.roomTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(82, 20);
            this.roomTypeLabel.TabIndex = 56;
            this.roomTypeLabel.Text = "Room type";
            this.roomTypeLabel.UseCustomBackColor = true;
            this.roomTypeLabel.UseCustomForeColor = true;
            // 
            // Todo
            // 
            this.Todo.BackColor = System.Drawing.Color.Transparent;
            this.Todo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Todo.Controls.Add(this.dinnerQTLabel);
            this.Todo.Controls.Add(this.lunchQTLabel);
            this.Todo.Controls.Add(this.breakfastQTLabel);
            this.Todo.Controls.Add(this.breakfastTextBox);
            this.Todo.Controls.Add(this.foodSelectionButton);
            this.Todo.Controls.Add(this.supplyCheckBox);
            this.Todo.Controls.Add(this.lunchTextBox);
            this.Todo.Controls.Add(this.towelCheckBox);
            this.Todo.Controls.Add(this.dinnerTextBox);
            this.Todo.Controls.Add(this.cleaningCheckBox);
            this.Todo.Controls.Add(this.surpriseCheckBox);
            this.Todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Todo.Location = new System.Drawing.Point(469, 55);
            this.Todo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Todo.Name = "Todo";
            this.Todo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Todo.Size = new System.Drawing.Size(465, 398);
            this.Todo.TabIndex = 55;
            this.Todo.TabStop = false;
            this.Todo.Text = "Todo";
            // 
            // dinnerQTLabel
            // 
            this.dinnerQTLabel.AutoSize = true;
            this.dinnerQTLabel.BackColor = System.Drawing.Color.Transparent;
            this.dinnerQTLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.dinnerQTLabel.Location = new System.Drawing.Point(23, 107);
            this.dinnerQTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dinnerQTLabel.Name = "dinnerQTLabel";
            this.dinnerQTLabel.Size = new System.Drawing.Size(93, 20);
            this.dinnerQTLabel.TabIndex = 63;
            this.dinnerQTLabel.Text = "Dinner [QTY]";
            this.dinnerQTLabel.UseCustomBackColor = true;
            this.dinnerQTLabel.UseCustomForeColor = true;
            // 
            // lunchQTLabel
            // 
            this.lunchQTLabel.AutoSize = true;
            this.lunchQTLabel.BackColor = System.Drawing.Color.Transparent;
            this.lunchQTLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lunchQTLabel.Location = new System.Drawing.Point(239, 30);
            this.lunchQTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lunchQTLabel.Name = "lunchQTLabel";
            this.lunchQTLabel.Size = new System.Drawing.Size(87, 20);
            this.lunchQTLabel.TabIndex = 62;
            this.lunchQTLabel.Text = "Lunch [QTY]";
            this.lunchQTLabel.UseCustomBackColor = true;
            this.lunchQTLabel.UseCustomForeColor = true;
            // 
            // breakfastQTLabel
            // 
            this.breakfastQTLabel.AutoSize = true;
            this.breakfastQTLabel.BackColor = System.Drawing.Color.Transparent;
            this.breakfastQTLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.breakfastQTLabel.Location = new System.Drawing.Point(23, 30);
            this.breakfastQTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breakfastQTLabel.Name = "breakfastQTLabel";
            this.breakfastQTLabel.Size = new System.Drawing.Size(110, 20);
            this.breakfastQTLabel.TabIndex = 61;
            this.breakfastQTLabel.Text = "Breakfast [QTY]";
            this.breakfastQTLabel.UseCustomBackColor = true;
            this.breakfastQTLabel.UseCustomForeColor = true;
            // 
            // breakfastTextBox
            // 
            this.breakfastTextBox.BackColor = System.Drawing.Color.White;
            this.breakfastTextBox.Enabled = false;
            //this.breakfastTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.breakfastTextBox.Lines = new string[0];
            this.breakfastTextBox.Location = new System.Drawing.Point(23, 57);
            this.breakfastTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.breakfastTextBox.MaxLength = 32767;
            this.breakfastTextBox.Name = "breakfastTextBox";
            this.breakfastTextBox.PasswordChar = '\0';
            //this.breakfastTextBox.PromptText = "Breakfast";
            this.breakfastTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.breakfastTextBox.SelectedText = "";
            this.breakfastTextBox.Size = new System.Drawing.Size(207, 36);
            this.breakfastTextBox.TabIndex = 47;
            //this.breakfastTextBox.UseCustomBackColor = true;
            //this.breakfastTextBox.UseSelectable = true;
            // 
            // foodSelectionButton
            // 
            this.foodSelectionButton.Location = new System.Drawing.Point(23, 340);
            this.foodSelectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foodSelectionButton.Name = "foodSelectionButton";
            this.foodSelectionButton.Size = new System.Drawing.Size(423, 38);
            this.foodSelectionButton.Style = MetroFramework.MetroColorStyle.Green;
            this.foodSelectionButton.TabIndex = 59;
            this.foodSelectionButton.Text = "Change food selection?";
            this.foodSelectionButton.UseSelectable = true;
            this.foodSelectionButton.UseStyleColors = true;
            this.foodSelectionButton.Click += new System.EventHandler(this.foodSelectionButton_Click);
            // 
            // supplyCheckBox
            // 
            this.supplyCheckBox.AutoSize = true;
            this.supplyCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.supplyCheckBox.Location = new System.Drawing.Point(168, 293);
            this.supplyCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplyCheckBox.Name = "supplyCheckBox";
            this.supplyCheckBox.Size = new System.Drawing.Size(146, 17);
            this.supplyCheckBox.Style = MetroFramework.MetroColorStyle.Lime;
            this.supplyCheckBox.TabIndex = 42;
            this.supplyCheckBox.Text = "Food/Supply status ?";
            this.supplyCheckBox.UseCustomBackColor = true;
            this.supplyCheckBox.UseSelectable = true;
            this.supplyCheckBox.CheckedChanged += new System.EventHandler(this.supplyCheckBox_CheckedChanged);
            // 
            // lunchTextBox
            // 
            this.lunchTextBox.BackColor = System.Drawing.Color.White;
            this.lunchTextBox.Enabled = false;
            // this.lunchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lunchTextBox.Lines = new string[0];
            this.lunchTextBox.Location = new System.Drawing.Point(239, 57);
            this.lunchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lunchTextBox.MaxLength = 32767;
            this.lunchTextBox.Name = "lunchTextBox";
            this.lunchTextBox.PasswordChar = '\0';
            //this.lunchTextBox.PromptText = "Lunch";
            this.lunchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lunchTextBox.SelectedText = "";
            this.lunchTextBox.Size = new System.Drawing.Size(207, 36);
            this.lunchTextBox.TabIndex = 48;
            // this.lunchTextBox.UseCustomBackColor = true;
            //this.lunchTextBox.UseSelectable = true;
            // 
            // towelCheckBox
            // 
            this.towelCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.towelCheckBox.Enabled = false;
            this.towelCheckBox.Location = new System.Drawing.Point(180, 209);
            this.towelCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.towelCheckBox.Name = "towelCheckBox";
            this.towelCheckBox.Size = new System.Drawing.Size(103, 36);
            this.towelCheckBox.Style = MetroFramework.MetroColorStyle.Lime;
            this.towelCheckBox.TabIndex = 52;
            this.towelCheckBox.Text = "Towels";
            this.towelCheckBox.UseCustomBackColor = true;
            this.towelCheckBox.UseSelectable = true;
            // 
            // dinnerTextBox
            // 
            this.dinnerTextBox.BackColor = System.Drawing.Color.White;
            this.dinnerTextBox.Enabled = false;
            //this.dinnerTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.dinnerTextBox.Lines = new string[0];
            this.dinnerTextBox.Location = new System.Drawing.Point(23, 134);
            this.dinnerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dinnerTextBox.MaxLength = 32767;
            this.dinnerTextBox.Name = "dinnerTextBox";
            this.dinnerTextBox.PasswordChar = '\0';
            //this.dinnerTextBox.PromptText = "Dinner";
            this.dinnerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dinnerTextBox.SelectedText = "";
            this.dinnerTextBox.Size = new System.Drawing.Size(423, 36);
            this.dinnerTextBox.TabIndex = 49;
            //this.dinnerTextBox.UseCustomBackColor = true;
            //this.dinnerTextBox.UseSelectable = true;
            // 
            // cleaningCheckBox
            // 
            this.cleaningCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.cleaningCheckBox.Enabled = false;
            this.cleaningCheckBox.Location = new System.Drawing.Point(29, 209);
            this.cleaningCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cleaningCheckBox.Name = "cleaningCheckBox";
            this.cleaningCheckBox.Size = new System.Drawing.Size(103, 36);
            this.cleaningCheckBox.Style = MetroFramework.MetroColorStyle.Lime;
            this.cleaningCheckBox.TabIndex = 51;
            this.cleaningCheckBox.Text = "Cleaning";
            this.cleaningCheckBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cleaningCheckBox.UseCustomBackColor = true;
            this.cleaningCheckBox.UseSelectable = true;
            // 
            // surpriseCheckBox
            // 
            this.surpriseCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.surpriseCheckBox.Enabled = false;
            this.surpriseCheckBox.Location = new System.Drawing.Point(291, 210);
            this.surpriseCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surpriseCheckBox.Name = "surpriseCheckBox";
            this.surpriseCheckBox.Size = new System.Drawing.Size(161, 34);
            this.surpriseCheckBox.Style = MetroFramework.MetroColorStyle.Lime;
            this.surpriseCheckBox.TabIndex = 50;
            this.surpriseCheckBox.Text = "Sweetest Surprise";
            this.surpriseCheckBox.UseCustomBackColor = true;
            this.surpriseCheckBox.UseSelectable = true;
            // 
            // floorNTextBox
            // 
            this.floorNTextBox.BackColor = System.Drawing.Color.White;
            this.floorNTextBox.Enabled = false;
            // this.floorNTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.floorNTextBox.Lines = new string[0];
            this.floorNTextBox.Location = new System.Drawing.Point(253, 265);
            this.floorNTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.floorNTextBox.MaxLength = 32767;
            this.floorNTextBox.Name = "floorNTextBox";
            this.floorNTextBox.PasswordChar = '\0';
            //this.floorNTextBox.PromptText = "Floor #";
            this.floorNTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.floorNTextBox.SelectedText = "";
            this.floorNTextBox.Size = new System.Drawing.Size(207, 36);
            this.floorNTextBox.TabIndex = 46;
            //this.floorNTextBox.UseCustomBackColor = true;
            //this.floorNTextBox.UseSelectable = true;
            // 
            // roomNTextBox
            // 
            this.roomNTextBox.BackColor = System.Drawing.Color.White;
            this.roomNTextBox.Enabled = false;
            //this.roomNTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.roomNTextBox.Lines = new string[0];
            this.roomNTextBox.Location = new System.Drawing.Point(41, 341);
            this.roomNTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomNTextBox.MaxLength = 32767;
            this.roomNTextBox.Name = "roomNTextBox";
            this.roomNTextBox.PasswordChar = '\0';
            // this.roomNTextBox.PromptText = "Room #";
            this.roomNTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.roomNTextBox.SelectedText = "";
            this.roomNTextBox.Size = new System.Drawing.Size(421, 36);
            this.roomNTextBox.TabIndex = 45;
            // this.roomNTextBox.UseCustomBackColor = true;
            //this.roomNTextBox.UseSelectable = true;
            // 
            // roomTypeTextBox
            // 
            this.roomTypeTextBox.BackColor = System.Drawing.Color.White;
            this.roomTypeTextBox.Enabled = false;
            //this.roomTypeTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.roomTypeTextBox.Lines = new string[0];
            this.roomTypeTextBox.Location = new System.Drawing.Point(39, 265);
            this.roomTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomTypeTextBox.MaxLength = 32767;
            this.roomTypeTextBox.Name = "roomTypeTextBox";
            this.roomTypeTextBox.PasswordChar = '\0';
            // this.roomTypeTextBox.PromptText = "Room type";
            this.roomTypeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.roomTypeTextBox.SelectedText = "";
            this.roomTypeTextBox.Size = new System.Drawing.Size(207, 36);
            this.roomTypeTextBox.TabIndex = 44;
            //this.roomTypeTextBox.UseCustomBackColor = true;
            // this.roomTypeTextBox.UseSelectable = true;
            // 
            // phoneNTextBox
            // 
            this.phoneNTextBox.BackColor = System.Drawing.Color.White;
            this.phoneNTextBox.Enabled = false;
            // this.phoneNTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.phoneNTextBox.Lines = new string[0];
            this.phoneNTextBox.Location = new System.Drawing.Point(41, 190);
            this.phoneNTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNTextBox.MaxLength = 32767;
            this.phoneNTextBox.Name = "phoneNTextBox";
            this.phoneNTextBox.PasswordChar = '\0';
            //this.phoneNTextBox.PromptText = "(999)-999-9999";
            this.phoneNTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneNTextBox.SelectedText = "";
            this.phoneNTextBox.Size = new System.Drawing.Size(421, 36);
            //this.phoneNTextBox.Style = MetroFramework.MetroColorStyle.Lime;
            this.phoneNTextBox.TabIndex = 43;
            // this.phoneNTextBox.UseCustomBackColor = true;
            // this.phoneNTextBox.UseSelectable = true;
            // 
            // queueListBox
            // 
            this.queueListBox.FormattingEnabled = true;
            this.queueListBox.ItemHeight = 16;
            this.queueListBox.Location = new System.Drawing.Point(943, 64);
            this.queueListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.Size = new System.Drawing.Size(297, 388);
            this.queueListBox.TabIndex = 40;
            this.queueListBox.SelectedIndexChanged += new System.EventHandler(this.queueListBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nameLabel.Location = new System.Drawing.Point(39, 85);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "Name";
            this.nameLabel.UseCustomBackColor = true;
            this.nameLabel.UseCustomForeColor = true;
            // 
            // phoneNLabel
            // 
            this.phoneNLabel.AutoSize = true;
            this.phoneNLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.phoneNLabel.Location = new System.Drawing.Point(40, 162);
            this.phoneNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNLabel.Name = "phoneNLabel";
            this.phoneNLabel.Size = new System.Drawing.Size(105, 20);
            this.phoneNLabel.TabIndex = 30;
            this.phoneNLabel.Text = "Phone number";
            this.phoneNLabel.UseCustomBackColor = true;
            this.phoneNLabel.UseCustomForeColor = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.Enabled = false;
            //this.firstNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.firstNameTextBox.Lines = new string[0];
            this.firstNameTextBox.Location = new System.Drawing.Point(40, 112);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameTextBox.MaxLength = 32767;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            //this.firstNameTextBox.PromptText = "First";
            this.firstNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(207, 36);
            // this.firstNameTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.firstNameTextBox.TabIndex = 21;
            // this.firstNameTextBox.UseCustomBackColor = true;
            //this.firstNameTextBox.UseSelectable = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.Enabled = false;
            // this.lastNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lastNameTextBox.Lines = new string[0];
            this.lastNameTextBox.Location = new System.Drawing.Point(255, 112);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            //this.lastNameTextBox.PromptText = "Last";
            this.lastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(207, 36);
            this.lastNameTextBox.TabIndex = 22;
            // this.lastNameTextBox.UseCustomBackColor = true;
            //this.lastNameTextBox.UseSelectable = true;
            // 
            // overviewTabPage
            // 
            this.overviewTabPage.Controls.Add(this.overviewDataGridView);
            this.overviewTabPage.HorizontalScrollbarBarColor = true;
            this.overviewTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.overviewTabPage.HorizontalScrollbarSize = 12;
            this.overviewTabPage.Location = new System.Drawing.Point(4, 38);
            this.overviewTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overviewTabPage.Name = "overviewTabPage";
            this.overviewTabPage.Size = new System.Drawing.Size(1303, 549);
            this.overviewTabPage.TabIndex = 1;
            this.overviewTabPage.Text = "Overview";
            this.overviewTabPage.VerticalScrollbarBarColor = true;
            this.overviewTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.overviewTabPage.VerticalScrollbarSize = 13;
            // 
            // overviewDataGridView
            // 
            this.overviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overviewDataGridView.Location = new System.Drawing.Point(0, 25);
            this.overviewDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overviewDataGridView.Name = "overviewDataGridView";
            this.overviewDataGridView.RowHeadersWidth = 51;
            this.overviewDataGridView.Size = new System.Drawing.Size(1300, 421);
            this.overviewDataGridView.TabIndex = 2;
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 677);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kitchen";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Room Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kitchen_FormClosing);
            this.Load += new System.EventHandler(this.kitchen_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.TodoTabPage.ResumeLayout(false);
            this.TodoTabPage.PerformLayout();
            this.Todo.ResumeLayout(false);
            this.Todo.PerformLayout();
            this.overviewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overviewDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TodoTabPage;
        private MetroFramework.Controls.MetroTabPage overviewTabPage;
        private System.Windows.Forms.DataGridView overviewDataGridView;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel phoneNLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private System.Windows.Forms.ListBox queueListBox;
        private TextBox phoneNTextBox;
        private MetroFramework.Controls.MetroCheckBox supplyCheckBox;
        private TextBox floorNTextBox;
        private TextBox roomNTextBox;
        private TextBox roomTypeTextBox;
        private MetroFramework.Controls.MetroCheckBox towelCheckBox;
        private MetroFramework.Controls.MetroCheckBox cleaningCheckBox;
        private MetroFramework.Controls.MetroCheckBox surpriseCheckBox;
        private TextBox dinnerTextBox;
        private TextBox lunchTextBox;
        private TextBox breakfastTextBox;
        private System.Windows.Forms.GroupBox Todo;
        private MetroFramework.Controls.MetroLabel roomNLabel;
        private MetroFramework.Controls.MetroLabel floorNLabel;
        private MetroFramework.Controls.MetroLabel roomTypeLabel;
        private MetroFramework.Controls.MetroButton foodSelectionButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroLabel dinnerQTLabel;
        private MetroFramework.Controls.MetroLabel lunchQTLabel;
        private MetroFramework.Controls.MetroLabel breakfastQTLabel;
        private MetroFramework.Controls.MetroLabel onTheLineLabel;

    }
}