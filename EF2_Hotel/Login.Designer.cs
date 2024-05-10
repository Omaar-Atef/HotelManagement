namespace Hotel_Manager
{
    partial class Login
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
            usernameLabel = new MetroFramework.Controls.MetroLabel();
            passwordLabel = new MetroFramework.Controls.MetroLabel();
            signinButton = new MetroFramework.Controls.MetroButton();
            LicenseCallButton = new MetroFramework.Controls.MetroButton();
            usernameText = new TextBox();
            passwordText = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            usernameLabel.ForeColor = Color.Black;
            usernameLabel.Location = new Point(323, 148);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.Style = MetroFramework.MetroColorStyle.Blue;
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            usernameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            passwordLabel.Location = new Point(323, 237);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.Style = MetroFramework.MetroColorStyle.Blue;
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            passwordLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            passwordLabel.Visible = false;
            // 
            // signinButton
            // 
            signinButton.DisplayFocus = true;
            signinButton.Location = new Point(220, 358);
            signinButton.Margin = new Padding(4, 5, 4, 5);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(271, 46);
            signinButton.Style = MetroFramework.MetroColorStyle.Green;
            signinButton.TabIndex = 6;
            signinButton.Text = "Sign in";
            signinButton.Theme = MetroFramework.MetroThemeStyle.Light;
            signinButton.UseCustomForeColor = true;
            signinButton.UseSelectable = true;
            signinButton.UseStyleColors = true;
            signinButton.Click += signinButton_Click;
            // 
            // LicenseCallButton
            // 
            LicenseCallButton.Location = new Point(624, 545);
            LicenseCallButton.Margin = new Padding(4, 5, 4, 5);
            LicenseCallButton.Name = "LicenseCallButton";
            LicenseCallButton.Size = new Size(64, 35);
            LicenseCallButton.TabIndex = 7;
            LicenseCallButton.Text = "License";
            LicenseCallButton.UseSelectable = true;
            LicenseCallButton.Click += LicenseCallButton_Click;
            // 
            // usernameText
            // 
            usernameText.Location = new Point(296, 191);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(125, 27);
            usernameText.TabIndex = 8;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(296, 276);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(125, 27);
            passwordText.TabIndex = 9;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(111, 194);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 20);
            labelUsername.TabIndex = 10;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(111, 276);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 580);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(LicenseCallButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(signinButton);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Login";
            Padding = new Padding(27, 92, 27, 31);
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Teal;
            Text = "Login";
            FormClosing += login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usernameTextBox;
        private MetroFramework.Controls.MetroButton signinButton;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroButton LicenseCallButton;
        private TextBox usernameText;
        private TextBox passwordText;
        private Label labelUsername;
        private Label labelPassword;
    }
}

