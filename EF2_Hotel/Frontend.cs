using MetroFramework.Forms;
using Microsoft.Data.SqlClient;
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
using System.Configuration;
using Twilio;
using Twilio.Clients;
using EF2_Hotel.Context;
using EF2_Hotel.Entities.FrontendEntitites;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Dapper;
namespace Hotel_Manager
{
    public partial class Frontend : MetroForm
    {
        string AccountSid = "ACcb86dacb791bef978628a2e16b1f7a24";
        string AuthToken = "3f344a07336d2e0ac5e467f72a1e650d";
        string RecvPhoneNumber = "";
        public Frontend()
        {
            InitializeComponent();
            CenterToScreen();
            entryDatePicker.MinDate = DateTime.Today;
            depDatePicker.MinDate = DateTime.Today.AddDays(1);

            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();

            this.roomOccupiedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomOccupiedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomOccupiedListBox_DrawItem);
            this.roomReservedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomReservedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomReservedListBox_DrawItem);
        }



        private void roomOccupiedListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.roomOccupiedListBox.IntegralHeight = false;
            this.roomOccupiedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomOccupiedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }
        private void roomReservedListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.roomReservedListBox.IntegralHeight = false;
            this.roomReservedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomReservedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }


        private string getval;

        public string Getval
        {
            get { return getval; }
            set { getval = value; }
        }

        public string towelS, cleaningS, surpriseS;

        public int foodBill;
        public string birthday = "";

        public string food_menu = "";
        public int totalAmount = 0;
        public bool checkin = false;
        public bool foodStatus = false;
        public Int32 primartyID = 0;
        public Boolean taskFinder = false;
        public Boolean editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private double finalizedTotalAmount = 0.0;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private string cleaning; private string towel;
        private string surprise;

        private void MainTab_Load(object sender, EventArgs e)
        {
            foodSupplyCheckBox.Enabled = false;

        }

        public void foodMenuButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    food_menu.breakfastCheckBox.Checked = true;
                    food_menu.breakfastQTY.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    food_menu.lunchCheckBox.Checked = true;

                    food_menu.launchQt.Text = Convert.ToString(lunch);
                }
                if (dinner > 0)
                {
                    food_menu.dinnerCheckBox.Checked = true;
                    food_menu.dinnerQTY.Text = Convert.ToString(dinner);
                }
                if (cleaning == "1")
                {
                    food_menu.cleaningCheckBox.Checked = true;
                }
                if (towel == "1")
                {
                    food_menu.towelsCheckBox.Checked = true;
                }
                if (surprise == "1")
                {
                    food_menu.surpriseCheckBox.Checked = true;
                }
            }
            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            cleaning = food_menu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? "true" : "false";
            towel = food_menu.Towel.Replace(" ", string.Empty) == "Towels" ? "true" : "false";

            surprise = food_menu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? "true" : "false";

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roomTypeComboBox.SelectedItem.Equals("Single"))
            {
                totalAmount = 149;
                floorComboBox.SelectedItem = "1";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Double"))
            {
                totalAmount = 299;
                floorComboBox.SelectedItem = "2";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Twin"))
            {
                totalAmount = 349;
                floorComboBox.SelectedItem = "3";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Duplex"))
            {
                totalAmount = 399;
                floorComboBox.SelectedItem = "4";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Suite"))
            {
                totalAmount = 499;
                floorComboBox.SelectedItem = "5";
            }
            int selectedTemp = 0;
            string selected;
            /*bool temp = int.TryParse(qtGuestComboBox.SelectedItem.ToString(), out selectedTemp);
            if (!temp)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = qtGuestComboBox.SelectedItem.ToString();
                selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }
            */

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editClicked = true;
            entryDatePicker.MinDate = new DateTime(2014, 4, 1);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Format = DateTimePickerFormat.Custom;

            depDatePicker.MinDate = new DateTime(2014, 4, 1);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Format = DateTimePickerFormat.Custom;

            submitButton.Visible = false;
            updateButton.Visible = true;
            deleteButton.Visible = true;
            resEditButton.Visible = true;
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
        }


        private void finalizeButton_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = true;
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == "0" && towel == "0" && surprise == "0")
            {
                foodSupplyCheckBox.Checked = true;
            }


            FinalizePayment finalizebil = new FinalizePayment();
            finalizebil.totalAmountFromFrontend = totalAmount;
            finalizebil.foodBill = foodBill;
            if (taskFinder)
            {
                finalizebil.paymentComboBox.SelectedItem = FPayment.Replace(" ", string.Empty);
                finalizebil.phoneComboBox.Text = FCnumber;
                finalizebil.monthComboBox.SelectedItem = FcardExpOne;
                finalizebil.yearComboBox.SelectedItem = FcardExpTwo;
                finalizebil.cvc.Text = FCardCVC;
            }

            finalizebil.ShowDialog();

            finalizedTotalAmount = finalizebil.FinalTotalFinalized;
            paymentType = finalizebil.PaymentType;
            paymentCardNumber = finalizebil.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil.MM_YY_Of_Card1;
            CVC_Of_Card = finalizebil.CVC_Of_Card1;
            CardType = finalizebil.CardType1;

            if (!editClicked)
            {
                submitButton.Visible = true;
            }
        }

        private void SendSMS(int secondUserID)
        {
            //creating an instance of twilio rest
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            string name = fnameTextBox.Text;

            string end_num = paymentCardNumber.Substring(paymentCardNumber.Length - Math.Min(4, paymentCardNumber.Length));

            if (smsCheckBox.Checked)
            {
                //building message for twilio
                string buildMesage = "Hello " + name + "! Your unique ID# " + secondUserID + " Total bill of $" + finalizedTotalAmount + " is charged on your card # ending-" + end_num;
                //creating message 
                //var message = twilio.SendMessage("+12034562736", RecvPhoneNumber, buildMesage, "");
                //sending message
                //Console.WriteLine(message.Sid);
                smsCheckBox.Text = "SMS Sent";
            }
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Reservation object and populate its properties
                Reservation reservation = new Reservation
                {
                    First_name = fnameTextBox.Text,
                    Last_name = lNametextBox.Text,
                    Birth_day = dateTimePickerBirthdate.Value.ToString(),
                    Gender = genderComboBox.SelectedItem.ToString(),
                    Phone_number = phoneTextBox.Text,
                    Email_address = textBoxEmail.Text,
                    Number_guest = qtGuestComboBox.SelectedIndex + 1,
                    Street_address = textBoxAddress.Text,
                    Apt_suite = "NA",
                    City = textBoxCity.Text,
                    State = stateComboBox.SelectedItem.ToString(),
                    Zip_code = "NA",
                    Room_type = roomTypeComboBox.SelectedItem.ToString(),
                    Room_floor = floorComboBox.SelectedItem.ToString(),
                    Room_number = roomNComboBox.SelectedItem.ToString(),
                    Total_bill = finalizedTotalAmount,
                    Payment_type = paymentType ?? "NA",
                    Card_type = CardType ?? "NA",
                    Card_number = paymentCardNumber ?? "NA",
                    Card_exp = MM_YY_Of_Card ?? "NA",
                    Card_cvc = CVC_Of_Card ?? "NA",
                    Arrival_time = entryDatePicker.Value,
                    Leaving_time = depDatePicker.Value,
                    Check_in = checkin,
                    Break_fast = breakfast,
                    Launch = lunch,
                    Dinner = dinner,
                    Supply_status = foodStatus,
                    Cleaning = Boolean.TryParse(cleaning, out bool myBool),
                    Towel = Boolean.TryParse(towel, out bool myBool2),
                    S_surprise = Boolean.TryParse(surprise, out bool myBool3),
                    Food_bill = foodBill
                };

                using (var dbContext = new FrontendContext())
                {
                    dbContext.Reservation.Add(reservation);
                    dbContext.SaveChanges();
                }

                int userID = reservation.Id;

                SendSMS(userID);

                // Show success message to the user
                MetroFramework.MetroMessageBox.Show(this, "Entry successfully inserted into database. " + "\n\n" +
                    "Provide this unique ID to the customer." + "\n\n" +
                    "USER UNIQUE ID: " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            // Update UI components
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            submitButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            resEditButton.Visible = false;
            reset_frontend();
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
        public void ClearAllComboBox(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control == roomTypeComboBox)
                {
                    continue;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren)
                {
                    ClearAllComboBox(control);
                }
            }
        }
        private void reset_frontend()
        {
            try
            {

                resEditButton.Items.Clear();
                checkinCheckBox.Checked = false;
                foodSupplyCheckBox.Checked = false;

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);

                ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (primartyID < 10000)
            {
                using (var dbContext = new FrontendContext())
                {
                    var deleted = dbContext.Reservation.FirstOrDefault(r => r.Id == primartyID);
                    if (deleted != null)
                    {
                        dbContext.Reservation.Remove(deleted);
                        dbContext.SaveChanges();
                        MessageBox.Show("Reservation For the UNIQUE USER ID of: " + "\n\n" +
                " " + primartyID + " is DELETED.", "Deleted");

                    }
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }


        private void updateButton_Click(object sender, EventArgs e)
        {

            birthday = dateTimePickerBirthdate.Text;
            using (var dbContext = new FrontendContext())
            {
                var reservation = dbContext.Reservation.FirstOrDefault(r => r.Id == primartyID);
                if (reservation != null)
                {
                    reservation.First_name = fnameTextBox.Text;
                    reservation.Last_name = lNametextBox.Text;
                    reservation.Birth_day = birthday;
                    reservation.Gender = genderComboBox.SelectedItem.ToString();
                    reservation.Phone_number = phoneTextBox.Text;
                    reservation.Email_address = textBoxEmail.Text;
                    reservation.Number_guest = qtGuestComboBox.SelectedIndex + 1;
                    reservation.Street_address = textBoxAddress.Text;
                    reservation.City = textBoxCity.Text;
                    reservation.State = stateComboBox.SelectedItem.ToString();
                    //reservation.Zip_code = zipComboBox.Text;
                    reservation.Room_type = roomTypeComboBox.SelectedItem.ToString();
                    reservation.Room_floor = floorComboBox.SelectedItem.ToString();
                    //reservation.Room_number = roomNComboBox.SelectedItem.ToString();
                    reservation.Total_bill = finalizedTotalAmount;

                    reservation.Arrival_time = entryDatePicker.Value;
                    reservation.Leaving_time = depDatePicker.Value;
                    reservation.Break_fast = breakfast;
                    reservation.Launch = lunch;
                    reservation.Dinner = dinner;
                    reservation.Supply_status = foodStatus;
					reservation.Cleaning = Boolean.TryParse(cleaning, out bool clean);
					reservation.Towel = Boolean.TryParse(towel, out bool Towel);
					reservation.S_surprise = Boolean.TryParse(surprise, out bool s);
					reservation.Food_bill = foodBill;
					reservation.Check_in = checkin;  

                    dbContext.SaveChanges();
                    MessageBox.Show("Entry successfully updated into database. For the UNIQUE USER ID of: " +
                        primartyID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    //SendSMS(primartyID);
                }
            }

            ComboBoxItemsFromDataBase();
            reset_frontend();
            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinCheckBox.Checked)
            {
                checkinCheckBox.Text = "Checked in";
                checkin = true;
            }
            else
            {
                checkin = false;
                checkinCheckBox.Text = "Check in ?";
            }
        }

        private void resEditButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                getChecked();
                string selectedItemId = resEditButton.Text.Split('|')[0].Trim();

                using (var connection = new SqlConnection("Data Source=.;Initial Catalog=FrontendDB;Integrated Security=True;Encrypt=False;")) // Replace 'connectionString' with your actual connection string
                {
                    connection.Open();
                    var reservation = connection.QueryFirstOrDefault<Reservation>("SELECT * FROM Reservation WHERE Id = @Id", new { Id = selectedItemId });

                    if (reservation != null)
                    {
                        taskFinder = true;
                        fnameTextBox.Text = reservation.First_name;
                        lNametextBox.Text = reservation.Last_name;
                        phoneTextBox.Text = reservation.Phone_number;
                        genderComboBox.SelectedItem = reservation.Gender;
                        dateTimePickerBirthdate.Text = reservation.Birth_day;
                        textBoxEmail.Text = reservation.Email_address;
                        qtGuestComboBox.SelectedItem = reservation.Number_guest;
                        textBoxAddress.Text = reservation.Street_address;
                        textBoxCity.Text = reservation.City;
                        stateComboBox.SelectedItem = reservation.State;
                        roomTypeComboBox.SelectedItem = reservation.Room_type;
                        floorComboBox.SelectedItem = reservation.Room_floor;
                        roomNComboBox.SelectedItem = reservation.Room_number;
                        checkinCheckBox.Checked = reservation.Check_in;
                        FPayment = reservation.Payment_type;
                        FCnumber = reservation.Card_number;
                        FCardCVC = reservation.Card_cvc;
                        FcardExpOne = reservation.Card_exp.Substring(0, reservation.Card_exp.IndexOf('/'));
                        FcardExpTwo = reservation.Card_exp.Substring(reservation.Card_exp.Length - Math.Min(2, reservation.Card_exp.Length));

                        if (int.TryParse(reservation.Break_fast.ToString(), out int breakfastVal))
                        {
                            breakfast = breakfastVal;
                        }
                        else
                        {
                            breakfast = 0;
                        }

                        if (int.TryParse(reservation.Launch.ToString(), out int lunchVal))
                        {
                            lunch = lunchVal;
                        }
                        else
                        {
                            lunch = 0;
                        }

                        if (int.TryParse(reservation.Dinner.ToString(), out int dinnerVal))
                        {
                            dinner = dinnerVal;
                        }
                        else
                        {
                            dinner = 0;
                        }

                        foodBill = reservation.Food_bill;
                        foodSupplyCheckBox.Checked = reservation.Supply_status;
                        entryDatePicker.Value = reservation.Arrival_time.Date;
                        depDatePicker.Value = reservation.Leaving_time.Date;

                        primartyID = reservation.Id;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Reservation with ID " + selectedItemId + " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }



        private void ComboBoxItemsFromDataBase()
        {
            try
            {
                using (var dbContext = new FrontendContext())
                {
                    var reservations = dbContext.Reservation.ToList();

                    resEditButton.Items.Clear();

                    foreach (var reservation in reservations)
                    {
                        string ID = reservation.Id.ToString();
                        string first_name = reservation.First_name;
                        string last_name = reservation.Last_name;
                        string phone_number = reservation.Phone_number;
                        resEditButton.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadForDataGridView()
        {
            using (var dbContext = new FrontendContext())
            {
                var reservation = dbContext.Reservation.ToList();
                resTotalDataGridView.DataSource = reservation;
            }

        }

        private void foodSupplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (foodSupplyCheckBox.Checked)
            {
                foodSupplyCheckBox.Text = "Food/Supply: Complete";
                foodStatus = true;
            }
            else
            {
                foodStatus = false;
                foodSupplyCheckBox.Text = "Food/Supply status?";
            }
        }

        private void GetOccupiedRoom()
        {
            roomOccupiedListBox.Items.Clear();
            using (var connection = new SqlConnection("Data Source=.;Initial Catalog=FrontendDB;Integrated Security=True;Encrypt=False;")) // Replace 'connectionString' with your actual connection string
            {
                connection.Open();
                var occupiedRooms = connection.Query<Reservation>("SELECT * FROM Reservation WHERE Check_in = @CheckIn", new { CheckIn = true }).ToList();

                foreach (var reservation in occupiedRooms)
                {
                    string room_number = reservation.Room_number;
                    string room_type = reservation.Room_type;
                    string ID = reservation.Id.ToString();
                    string first_name = reservation.First_name;
                    string last_name = reservation.Last_name;
                    string phone_number = reservation.Phone_number;
                    string arrival_time = reservation.Arrival_time.ToString();
                    string dep_time = reservation.Leaving_time.ToString();

                    roomOccupiedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                        " " + room_type.Replace(" ", string.Empty) +
                        " " + ID.Replace(" ", string.Empty) +
                        " " + "[" + first_name.Replace(" ", string.Empty) +
                        " " + last_name.Replace(" ", string.Empty) + "]" +
                        " " + phone_number.Replace(" ", string.Empty));
                }
            }
        }


        private void ReservedRoom()
        {
            roomReservedListBox.Items.Clear();
            using (var dbContext = new FrontendContext())
            {
                var reservedRooms = (from r in dbContext.Reservation
                                     where r.Check_in == false
                                     select r).ToList();
                foreach (var reservation in reservedRooms)
                {
                    string room_number = reservation.Room_number;
                    string room_type = reservation.Room_type;
                    string ID = reservation.Id.ToString();
                    string first_name = reservation.First_name;
                    string last_name = reservation.Last_name;
                    string phone_number = reservation.Phone_number;

                    string arrival_date = reservation.Arrival_time.ToString("MM-dd-yyyy");
                    string leaving_date = reservation.Leaving_time.ToString("MM-dd-yyyy");

                    roomReservedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                        " " + room_type.Replace(" ", string.Empty) +
                        " " + ID.Replace(" ", string.Empty) +
                        " " + first_name.Replace(" ", string.Empty) +
                        " " + last_name.Replace(" ", string.Empty) +
                        " " + phone_number.Replace(" ", string.Empty) +
                        " " + arrival_date.Replace(" ", string.Empty) +
                        " " + leaving_date.Replace(" ", string.Empty));
                }
            }


        }


        private void getChecked()
        {
            using (var dbContext = new FrontendContext())
            {
                var takenRooms = (from r in dbContext.Reservation
                                  where r.Check_in == true
                                  select r.Room_number).ToList();

                foreach (var room_number in takenRooms)
                {
                    if (roomNComboBox.Items.Contains(room_number))
                    {
                        roomNComboBox.Items.Remove(room_number);
                    }
                }
            }
        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            RecvPhoneNumber = "+1" + phoneNumberTextBox.Text.Replace(" ", string.Empty);
            long getphn = Convert.ToInt64(phoneNumberTextBox.Text);
            string formatString = String.Format("{0:(000)000-0000}", getphn);
            phoneNumberTextBox.Text = formatString;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection("Data Source=.;Initial Catalog=FrontendDB;Integrated Security=True;Encrypt=False;"))
                {
                    connection.Open();
                    var query = connection.Query<Reservation>("SELECT * FROM Reservation " +
                                                               "WHERE Id LIKE @SearchText " +
                                                                  "OR Last_name LIKE @SearchText " +
                                                                  "OR First_name LIKE @SearchText " +
                                                                  "OR Gender LIKE @SearchText " +
                                                                  "OR State LIKE @SearchText " +
                                                                  "OR City LIKE @SearchText " +
                                                                  "OR Room_number LIKE @SearchText " +
                                                                  "OR Room_type LIKE @SearchText " +
                                                                  "OR Email_address LIKE @SearchText " +
                                                                  "OR Phone_number LIKE @SearchText",
                                                                  new { SearchText = "%" + searchTextBox.Text + "%" })
                                           .ToList();

                    searchDataGridView.DataSource = null;
                    searchDataGridView.Rows.Clear();

                    if (query.Any())
                    {
                        searchDataGridView.Visible = true;
                        searchButton.Location = new Point(752, 7);
                        searchTextBox.Location = new Point(68, 7);

                        searchDataGridView.DataSource = query;
                    }
                    else
                    {
                        searchDataGridView.Visible = false;
                        SearchError.Visible = true;
                        SearchError.Text = "SORRY DUDE :(" + "\n" +
                                           "I ran out of gas trying to search for " + searchTextBox.Text + "\n" +
                                           "I'm sure will find it next time.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
