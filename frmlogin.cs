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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
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

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnloginadmin_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                MessageBox.Show(" Please fill-up the data fields");
            }
            else if (TextBox1.Text != TextBox2.Text)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into signupdb.admin(Username,Password)values('" + this.TextBox1.Text + "','" + this.TextBox2.Text + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string. a 
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
                MessageBox.Show("Admin successfull login");
                Fromdashboard ara = new Fromdashboard();
                ara.Show();
                this.Hide();
            }
            else
            {
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
