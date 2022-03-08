using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewSystem
{
    public partial class addresidences : UserControl
    {
        public addresidences()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Show();
            if (SurnameTextBox1.Text == "" || FnameTextBox2.Text == "" || MnameTextBox3.Text == "" || SGcomboBox1.Text == "" || MonthcomboBox2.Text == "" || DaycomboBox3.Text == "" || YearcomboBox4.Text == "" || POBTextBox4.Text == "" || CScomboBox5.Text == "" || CitizenTextBox5.Text == "" || ReligionTextBox6.Text == "" || EATextBox7.Text == "" || OccTextBox8.Text == "" || HNTextBox9.Text == "" || ZSPTextBox10.Text == "")
            {
                MessageBox.Show(" Please fill-up the data fields");
            }
            else
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into signupdb.add_residence(Surname,First_name,Middle_name,Sex_Gender,Month,Day,Year,Place_of_Birth,Civil_Status,Citizenship,Religion,Educational_Attachment,Occupation,House_No,Zone_Street_Purok)values('" + this.SurnameTextBox1.Text + "','" + this.FnameTextBox2.Text + "','" + this.MnameTextBox3.Text + "','" + this.SGcomboBox1.Text + "','" + this.MonthcomboBox2.Text + "','" + this.DaycomboBox3.Text + "','" + this.YearcomboBox4.Text + "','" + this.POBTextBox4.Text + "','" + this.CScomboBox5.Text + "','" + this.CitizenTextBox5.Text + "','" + this.ReligionTextBox6.Text + "','" + this.EATextBox7.Text + "','" + this.OccTextBox8.Text + "','" + this.HNTextBox9.Text + "','" + this.ZSPTextBox10.Text + "');";
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
            }
        }
    }
}
