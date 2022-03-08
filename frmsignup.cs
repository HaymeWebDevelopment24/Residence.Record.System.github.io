using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewSystem
{
    public partial class frmsignup : Form
    {
        public frmsignup()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            this.Show();
            if (First_nameTextBox.Text == "" || Middle_nameTextBox.Text == "" || Last_nameTextBox.Text == "" || AddressTextBox.Text == "" || Contact_noTextBox.Text == "" || AgecomboBox.Text == "" || User_nameTextBox.Text == "" || PasswordTextBox.Text == "" || Re_passwordTextBox.Text == "" || User_typecomboBox.Text == "")
            {
                MessageBox.Show(" Please fill-up the data fields");

            }
            else if (PasswordTextBox.Text != Re_passwordTextBox.Text)
            {
                MessageBox.Show("Password does not match");
            }
            else
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into signupdb.register_table(First_name,Middle_name,Last_name,Address,Contact_no,Age,User_name,Password,Re_password,User_type)values('" + this.First_nameTextBox.Text + "','" + this.Middle_nameTextBox.Text + "','" + this.Last_nameTextBox.Text + "','" + this.AddressTextBox.Text + "','" + this.Contact_noTextBox.Text + "','" + this.AgecomboBox.Text + "','" + this.User_nameTextBox.Text + "','" + this.PasswordTextBox.Text + "','" + this.Re_passwordTextBox.Text + "','" + this.User_typecomboBox.Text + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    while (MyReader2.Read())
                    {

                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Save Data Successfully");
                this.Hide();
                frmAdmin lf = new frmAdmin();
                lf.Show();
            }
        }

        private void btnsignupexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do want to Exit are you Sure??", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmAdmin ar = new frmAdmin();
                ar.Show();
                this.Hide();
            }
            else
            {
                this.Activate();
            }
        }
    }
}
