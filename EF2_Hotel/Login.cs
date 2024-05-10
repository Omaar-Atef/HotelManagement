using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using EF2_Hotel.Context;

namespace Hotel_Manager
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
            //loginContext = new LoginContext();
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifier("frontend".Trim(), usernameText.Text.Trim(), passwordText.Text.Trim()))
                {
                    this.Hide();
                    Frontend hotel_management = new Frontend();
                    hotel_management.Show();
                }
                else if (verifier("kitchen".Trim(), usernameText.Text.Trim(), passwordText.Text.Trim()))
                {
                    this.Hide();
                    Kitchen kitchen_management = new Kitchen();
                    kitchen_management.Show();
                }
                else
                {
                    Trace.WriteLine("WrongPas");
                    MetroFramework.MetroMessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //Trace.WriteLine("Error occurred: " + ex.Message);
                //MessageBox.Show("Username or Password is wrong, try again, Login Failed");
            }
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!usernameLabel.Bounds.Contains(e.Location) && usernameText.Text == string.Empty)
            {
                usernameLabel.Visible = false;
            }
            if (!passwordLabel.Bounds.Contains(e.Location) && passwordText.Text == string.Empty)
            {
                passwordLabel.Visible = false;
            }

        }
        LoginContext loginContext;
        public bool verifier(string tableName, string username, string password)
        {
            bool success = false;

            loginContext = new LoginContext();
            switch (tableName)
            {
                case "frontend":
                    success = loginContext.Frontend.Any(u => u.User_name == username && u.Pass_word == password);

                    break;
                case "kitchen":
                    success = loginContext.Kitchen.Any(u => u.User_name == username && u.Pass_word == password);
                    break;
            }

            return success;
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginContext.Dispose(); 

            Application.Exit();
        }

        private void LicenseCallButton_Click(object sender, EventArgs e)
        {
            //License open_license = new License();
            //open_license.ShowDialog();
        }
    }
}
