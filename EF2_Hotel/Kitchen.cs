using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using EF2_Hotel.Context;
using Microsoft.Data.SqlClient;
using Dapper;

namespace Hotel_Manager
{
    public partial class Kitchen : MetroForm
    {
        string cleaning, towel, surprise, queryString;
        int breakfast, lunch, dinner, foodBill;
        public Int32 primaryID;
        double totalBill;
        bool supply_status = false;



        public Kitchen()
        {
            InitializeComponent();
        }
        private void kitchen_Load(object sender, EventArgs e)
        {
            LoadForDataGridView();
            listBoxFromDataBase();
        }

        private void LoadForDataGridView()
        {
            using (var connection = new SqlConnection("Data Source=.;Initial Catalog=FrontendDB;Integrated Security=True;Encrypt=False;"))
            {
                connection.Open();
                var reservations = connection.Query("SELECT Id, First_name, Last_name, Phone_number," +
                    " Room_type, Room_floor, Room_number, Break_fast, Launch, Dinner, Cleaning, Towel, " +
                    "S_surprise, Supply_status, Food_bill FROM Reservation WHERE Check_in = 1 " +
                    "AND Supply_status = 0").ToList();

                overviewDataGridView.DataSource = reservations;
            }
        }


        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    resetEntries(control);
                }
            }

        }
        private void listBoxFromDataBase()
        {
            queueListBox.Items.Clear();
            using (var dbContext = new FrontendContext())
            {
                var reservations = dbContext.Reservation.Where(r => r.Check_in == true && r.Supply_status == false).ToList();

                foreach (var r in reservations)
                {
                    string ID = r.Id.ToString();
                    string first_name = r.First_name.ToString();
                    string last_name = r.Last_name.ToString();
                    string phone_number = r.Phone_number.ToString();
                    queueListBox.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);
                }
            }


        }
        //////////////////////////////////////////////////
        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetEntries(this);
            string selectedItemId = queueListBox.Text.Substring(0, 3).Replace(" ", string.Empty);

            using (var dbContext = new FrontendContext())
            {
                var reservation = dbContext.Reservation.FirstOrDefault(r => r.Id.ToString() == selectedItemId);
                if (reservation != null)
                {
                    firstNameTextBox.Text = reservation.First_name;
                    lastNameTextBox.Text = reservation.Last_name;
                    phoneNTextBox.Text = reservation.Phone_number;
                    roomTypeTextBox.Text = reservation.Room_type;
                    floorNTextBox.Text = reservation.Room_floor;
                    roomNTextBox.Text = reservation.Room_number;
                    foodBill = reservation.Food_bill;

                    cleaningCheckBox.Checked = reservation.Cleaning;
                    towelCheckBox.Checked = reservation.Towel;
                    surpriseCheckBox.Checked = reservation.S_surprise;

                    supplyCheckBox.Checked = reservation.Supply_status;

                    breakfastTextBox.Text = reservation.Break_fast.ToString();
                    lunchTextBox.Text = reservation.Launch.ToString();
                    dinnerTextBox.Text = reservation.Dinner.ToString();

                    if (reservation.Cleaning)
                    {
                        cleaning = "1";
                    }
                    else { cleaning = "0"; }

                    if (reservation.Towel)
                    {
                        towel = "1";
                    }
                    else { towel = "0"; }
                    if (reservation.S_surprise)
                    {
                        surprise = "1";
                    }
                    else
                    {
                        surprise = "0";
                    }


                    // Set the total bill
                    totalBill = reservation.Total_bill - foodBill;

                    // Store the primary ID
                    primaryID = reservation.Id;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Reservation with ID " + selectedItemId + " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void foodSelectionButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            food_menu.needPanel.Visible = false;

            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            int bfast = 0, Lnch = 0, di_ner = 0;
            if (breakfast > 0)
            {
                bfast = 7 * breakfast;
            }
            if (lunch > 0)
            {
                Lnch = 15 * lunch;
            }
            if (dinner > 0)
            {
                di_ner = 15 * dinner;
            }
            foodBill += (bfast + Lnch + di_ner);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var dbContext = new FrontendContext())
            {
                if (primaryID < 1000)
                {
                    var reservation = dbContext.Reservation.FirstOrDefault(r => r.Id == primaryID);

                    if (reservation != null)
                    {
                        reservation.Total_bill = totalBill + foodBill;
                        reservation.Break_fast = breakfast;
                        reservation.Launch = lunch;
                        reservation.Dinner = dinner;
                        reservation.Supply_status = supply_status;
                        reservation.Cleaning = Convert.ToBoolean(Convert.ToInt32(cleaning));
                        reservation.Towel = Convert.ToBoolean(Convert.ToInt32(towel));
                        reservation.S_surprise = Convert.ToBoolean(Convert.ToInt32(surprise));
                        reservation.Food_bill = foodBill;

                        dbContext.SaveChanges();

                        MessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + primaryID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        // Refresh listboxes and clear form entries
                        listBoxFromDataBase();
                        LoadForDataGridView();
                        resetEntries(this);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }

        }

        private void supplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cleaningCheckBox.Checked = false;
            cleaningCheckBox.Text = "Cleaned";
            towelCheckBox.Checked = false;
            towelCheckBox.Text = "Toweled";
            surpriseCheckBox.Checked = false;
            surpriseCheckBox.Text = "Surprised";
            supply_status = true;
        }
        private void kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
