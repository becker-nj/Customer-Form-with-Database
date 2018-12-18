/*
 * Nathan Becker
 * IS1552
 * Bates
 * Assignment 5
 * 11/7/2018
 * Provide a form for employees to edit a database of customer information. With format checking of input using regex.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace is1552_Assignment5
{
    public partial class customerUpdateFRM : Form
    {
        public customerUpdateFRM()
        {
            InitializeComponent();
        }

        OleDbConnection connectionObject = new OleDbConnection();
        string currentCustomer = "";
        string currentZipcode = "";

        //Establish a connection to the database. 
        public void openDatabase()
        {
            try
            {
                string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=assignment5Database.accdb;Persist Security Info=False;";
                // add connectionString property to the connector
                connectionObject.ConnectionString = connectionStr;
                // open database connection
                connectionObject.Open();
            }
            catch (Exception ex)
            {
                // error message if database could not open
                MessageBox.Show("Database could not open because: " + ex,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Clear all form controls
        public void clearForm()
        {
            customerCMBOX.SelectedIndex = -1;
            customerZipCMBOX.SelectedIndex = -1;
            customerNameTXT.Clear();
            customerAddressTXT.Clear();
            customerCityTXT.Clear();
            customerStateTXT.Clear();
            customerEmailTXT.Clear();
            customerPhnNumTXT.Clear();
        }

        // fill customer number combo box
        public void fillComboBox()
        {
            try
            {
                // clear customer number data set
                customerNumDS.Clear();
                customerCMBOX.DisplayMember = "";
                customerCMBOX.ValueMember = "";

                // select customer ids
                string sql = "select distinct customer_id from customers order by customer_id";

                // use adapter to send query to database
                OleDbDataAdapter daCustomerNum = new OleDbDataAdapter(sql, connectionObject);

                // fill customer id data set
                daCustomerNum.Fill(customerNumDS, "customers");

                // assign data source to customer id combobox
                customerCMBOX.DataSource = customerNumDS.Tables[0];
                customerCMBOX.DisplayMember = "customers";
                customerCMBOX.ValueMember = "customer_id";
            }
            catch (Exception ex)
            {
                // display message if id numbers could not be pulled
                MessageBox.Show("Trouble pulling customer ids from database because: " + ex,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Function to fill the zip codes combobox with data from the zip code db table
        public void fillZipComboBox()
        {
            try
            {
                // clear customer number data set
                customerZipDS.Clear();
                customerZipCMBOX.DisplayMember = "";
                customerZipCMBOX.ValueMember = "";

                // select customer codes
                string sql = "select distinct zip_code from zip_code_tbl order by zip_code";

                // use adapter to send query to database
                OleDbDataAdapter daCourseNum = new OleDbDataAdapter(sql, connectionObject);

                // fill customer number data set
                daCourseNum.Fill(customerZipDS, "zipcodes");

                // assign data source to course code combobox
                customerZipCMBOX.DataSource = customerZipDS.Tables[0];
                customerZipCMBOX.DisplayMember = "zipcodes";
                customerZipCMBOX.ValueMember = "zip_code";
            }
            catch (Exception ex)
            {
                // display message if id numbers could not be pulled
                MessageBox.Show("Trouble pulling courses from database because: " + ex,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        //Function to check all the user input fields when the 
        //user attempts to update or add a customer
        private bool checkDataValidity()
        {
            //Grab current field text
            string name = customerNameTXT.Text;
            string email = customerEmailTXT.Text;
            string phnNum = customerPhnNumTXT.Text;

            //Assume everything is invalid
            bool validName, validEmail, validPhnNum = false;
            bool validData = false;
            //String to store fields that need correction.
            string fieldsToCorrect = "";

            //Check if the name contains at least one digit.
            //If it does it needs to be fixed.
            if (!Regex.IsMatch(name, @"\d"))
            {
                validName = true;
                customerNameTXT.BackColor = Color.White;
            }
            else
            {
                validName = false;
                fieldsToCorrect += " Name\n";
                customerNameTXT.BackColor = Color.Red;
            }
        
            //Check if phone number matches (xxx)-xxx-xxxx with no extra chars
            //Where x is a number 0-9
            if(Regex.IsMatch(phnNum, @"\B\(\d{3}\)\d{3}-\d{4}\b"))
            {
                validPhnNum = true;
                customerPhnNumTXT.BackColor = Color.White;
            }
            else
            {
                validPhnNum = false;
                fieldsToCorrect += " Phone Number\n";
                customerPhnNumTXT.BackColor = Color.Red;
            }

            //Check if the email starts with any num of characters
            //then an @ symbol
            //Then any number of characters
            //Then a .
            //Then any 3 characters
            if(Regex.IsMatch(email, @"\b\w*\b@\w*\..{3}\b"))
            {
                validEmail = true;
                customerEmailTXT.BackColor = Color.White;
            }
            else
            {
                validEmail = false;
                fieldsToCorrect += " E-mail Address\n";
                customerEmailTXT.BackColor = Color.Red;
            }

            //If every verified field has passed, we can now submit the update or addition
            //of a customer.
            if(validName == true && validEmail == true && validPhnNum == true)
            {
                validData = true;
            }
            else
            {
                MessageBox.Show("Please correct these fields in red and submit again:\n" +
                    fieldsToCorrect,
                   "Error In " + fieldsToCorrect + "Formatting",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

            return validData;
        }

        //Event handler to connect to database and fill combox upon loading the form.
        private void customerUpdateFRM_Load(object sender, EventArgs e)
        {
            try
            {
                openDatabase(); // open database
                fillZipComboBox(); //fill zip codes in combo box
                fillComboBox(); // fill course ids in combo box       
                clearForm(); //Clear the form
                //Disable deletion and update because no customer
                //is selected yet
                customerDeleteBTN.Enabled = false;
                updateCustomerBTN.Enabled = false;
            }
            catch (Exception errorMessage)
            {
                MessageBox.Show("Error while loading form: " + errorMessage.Message,
                    "Error Loading Form",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        //Event handler to update customer information displayed when combobox customer_id is changed.
        private void customerCMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currentCustomer = customerCMBOX.Text;

                if (currentCustomer != "System.Data.DataRowView" && currentCustomer != "")
                {
                    customerDeleteBTN.Enabled = true;
                    updateCustomerBTN.Enabled = true;
                    //Query to get customer info
                    string customerInfoSQL = "SELECT " +
                        "customers.[cust_name], customers.[address], customers.[zip_code], customers.[email_address], customers.[phone_number] " +
                        "FROM customers " +
                        "where customers.[customer_id] = " + Convert.ToInt32(currentCustomer) ;

                    OleDbCommand customerInfoCommand = new OleDbCommand(customerInfoSQL, connectionObject);

                    OleDbDataReader customerInfoReader = null;
                    customerInfoReader = customerInfoCommand.ExecuteReader();
                    customerInfoReader.Read();

                    //Fill boxes with customer info
                    customerNameTXT.Text = customerInfoReader[0].ToString();
                    customerAddressTXT.Text = customerInfoReader[1].ToString();
                    //Find the index of the zipcode we need to display and choose it.
                    customerZipCMBOX.SelectedIndex = customerZipCMBOX.FindStringExact(customerInfoReader[2].ToString());
                    customerEmailTXT.Text = customerInfoReader[3].ToString();
                    customerPhnNumTXT.Text = customerInfoReader[4].ToString();

                    //Enable buttons to be clicked.
                    updateCustomerBTN.Enabled = true;
                    customerDeleteBTN.Enabled = true;
                    customerAddBTN.Enabled = true;
                }
            }

            catch (Exception errMsg)
            {
                MessageBox.Show("Error in Customer ID Selected Index Change:  " + errMsg.Message,
                   "Error In Customer ID Selected Index Change",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        //If the zipcode is updated, we need to make sure the corresponding city and state are correct.
        private void customerZipCMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
             try
            {
                currentZipcode = customerZipCMBOX.Text;

                if (currentZipcode != "System.Data.DataRowView" && currentZipcode != "")
                {
                    //Query to get zipcode info
                    string zipInfoSQL = "SELECT " +
                        "zip_code_tbl.[city], zip_code_tbl.[state] FROM zip_code_tbl " +
                        "where zip_code_tbl.[zip_code] = '" + currentZipcode + "'";

                    OleDbCommand zipInfoCommand = new OleDbCommand(zipInfoSQL, connectionObject);

                    OleDbDataReader zipInfoReader = null;
                    zipInfoReader = zipInfoCommand.ExecuteReader();
                    zipInfoReader.Read();

                    //Fill boxes with state and city corresponding to zipcode 
                    customerCityTXT.Text = zipInfoReader[0].ToString();
                    customerStateTXT.Text = zipInfoReader[1].ToString();
                }
            }

            catch (Exception errMsg)
            {
                MessageBox.Show("Error in Zipcode Selected Index Change:  " + errMsg.Message,
                   "Error In Zipcode Selected Index Change",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        //Event handler for when the user clicks the update button
        //Sends updated customer info to the database for updating
        private void updateCustomerBTN_Click(object sender, EventArgs e)
        {
            try
            {

                if (updateCustomerBTN.Text == "Update")
                {
                    //Delete and add buttons disabled.
                    customerDeleteBTN.Enabled = false;
                    customerAddBTN.Enabled = false;

                    //Name, address, zip can now be updated.
                    customerNameTXT.ReadOnly = false;
                    customerAddressTXT.ReadOnly = false;
                    customerPhnNumTXT.ReadOnly = false;
                    customerEmailTXT.ReadOnly = false;
                    customerZipCMBOX.Enabled = true;

                    //Don't change to a new customer while we are 
                    //updating one already
                    customerCMBOX.Enabled = false;

                    updateCustomerBTN.Text = "Save These Changes";
                }

                else if (updateCustomerBTN.Text == "Save These Changes" && checkDataValidity())
                {
                    //Customer information to send to database
                    string customerName = customerNameTXT.Text;
                    string address = customerAddressTXT.Text;
                    string email = customerEmailTXT.Text;
                    string phnNum = customerPhnNumTXT.Text;
                    string zip = customerZipCMBOX.Text;

                    //SQL command to update the customer we want to update
                    string updateSQL = "update customers set " +
                        "cust_name = '" + customerName + 
                        "', address = '" + address +
                        "', zip_code = '" + zip + 
                        "', email_address = '" + email +
                        "', phone_number = '" + phnNum +
                        "' where customer_id = " + Convert.ToInt32(currentCustomer);

                    OleDbCommand updateOBJ = new OleDbCommand(updateSQL, connectionObject);
                    updateOBJ.ExecuteNonQuery();

                    //Enable buttons again now that we are done.
                    customerDeleteBTN.Enabled = true;
                    customerAddBTN.Enabled = true;

                    //Set controls back to how they were before updating customer
                    customerNameTXT.ReadOnly = true;
                    customerAddressTXT.ReadOnly = true;
                    customerZipCMBOX.Enabled = false;
                    customerCMBOX.Enabled = true;
                    customerPhnNumTXT.ReadOnly = true;
                    customerEmailTXT.ReadOnly = true;

                    updateCustomerBTN.Text = "Update";

                    MessageBox.Show("The customer was updated successfully.",
                        "Update Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }

            catch (Exception errMsg)
            {
                MessageBox.Show("Error in Update Customer Event Handler:  " + errMsg.Message,
                   "Error In Update Customer Event Handler",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        //Event handler for when the user clicks the delete button
        //Removes the currently selected customer from the database.
        private void customerDeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //Ask user if they are sure, yes or no.
                DialogResult sure;
                sure = MessageBox.Show("Are you sure you want to delete this customer?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                //User decided yes so we will continue with deletion.
                if (sure == DialogResult.Yes)
                {
                    //Query to remove current customer from database
                    string deleteSQL = "delete from customers where customer_id = " +
                        Convert.ToInt32(currentCustomer);
                    OleDbCommand deleteCommand = new OleDbCommand(deleteSQL, connectionObject);
                    deleteCommand.ExecuteNonQuery();
                    clearForm();

                    MessageBox.Show("Customer was successfully deleted.",
                        "Customer Delete Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    customerCMBOX.Text = "";
                    fillComboBox();
                }
            }
            catch (Exception errMsg)
            {
                MessageBox.Show("Error in Delete Button Event Handler:  " + errMsg.Message,
                   "Error In Delete Button Event Handler",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        //Event handler for when the user clicks add.
        //If user hits it again(insert) we send current form info to the 
        //databaes as a new customer
        private void customerAddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerAddBTN.Text == "Add")
                {
                    //Let user fill in form for new customer info
                    customerNameTXT.ReadOnly = false;
                    customerAddressTXT.ReadOnly = false;
                    customerEmailTXT.ReadOnly = false;
                    customerPhnNumTXT.ReadOnly = false;
                    customerZipCMBOX.Enabled = true;
                    clearForm();

                    customerAddBTN.Text = "Insert Customer";

                    //Prevent the user from clicking a different customer
                    customerCMBOX.Enabled = false;
                    //Prevent user from clicking a different button while in insert mode
                    updateCustomerBTN.Enabled = false;
                    customerDeleteBTN.Enabled = false;
                }
                else if(customerAddBTN.Text == "Insert Customer" && checkDataValidity())
                {
                    //Customer information from form
                    string customerName = customerNameTXT.Text;
                    string address = customerAddressTXT.Text;
                    string zip = customerZipCMBOX.Text;
                    string email = customerEmailTXT.Text;
                    string phnNum = customerPhnNumTXT.Text;

                    string maxid;
                    string newid;

                    //SQL command to find highest primary key currently
                    string maxidSQL = "select max(customer_id) from customers";

                    OleDbCommand addCustomer = new OleDbCommand(maxidSQL, connectionObject);

                    OleDbDataReader readerObject = null;
                    readerObject = addCustomer.ExecuteReader();
                    readerObject.Read();
                    maxid = readerObject[0].ToString();
                    newid = (Convert.ToDouble(maxid) + 1).ToString();

                    //SQL command to insert a new customer with complete information
                    string insertSQL = "insert into customers " +
                        "(customer_id, cust_name, address, zip_code, email_address, phone_number) " +
                        "values (" + newid + ", '" + customerName + "', '" +
                        address + "', '" + zip + "', '" + email + "', '" + phnNum + "')";

                    addCustomer = new OleDbCommand(insertSQL, connectionObject);
                    addCustomer.ExecuteNonQuery();

                    MessageBox.Show("New customer was added successfully.",
                        "Custopmer Add Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    //Make the form not editable now that we are done inserting a new customer
                    customerNameTXT.ReadOnly = true;
                    customerAddressTXT.ReadOnly = true;
                    customerZipCMBOX.Enabled = false;
                    customerPhnNumTXT.ReadOnly = true;
                    customerEmailTXT.ReadOnly = true;

                    customerAddBTN.Text = "Add";

                    customerCMBOX.Enabled = true;
                    //Allow user to use all buttons again
                    updateCustomerBTN.Enabled = true;
                    customerDeleteBTN.Enabled = true;

                    //Refil combobox to get new customerid we just added
                    fillComboBox();
                    //Set the previously added customer as the chosen customer to display in form
                    customerCMBOX.SelectedIndex = customerCMBOX.FindStringExact(newid);
                }
            }
            catch (Exception errMsg)
            {
                MessageBox.Show("Error in Add Button Event Handler:  " + errMsg.Message,
                   "Error In Add Button Event Handler",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
    }
}
