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
    public partial class Fromdashboard : Form
    {
        public Fromdashboard()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Fromdashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            registeredlogs1.Visible = false;
            addresidences1.Visible = false;
        }

        private void btnlogs_Click(object sender, EventArgs e)
        {
            registeredlogs1.Visible = true;
            home1.Visible = false;
            addresidences1.Visible = false;
        }

        private void btnaddresidence_Click(object sender, EventArgs e)
        {
            addresidences1.Visible = true;
            registeredlogs1.Visible = false;
            home1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do want to Exit are you Sure??", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmlogin ar = new frmlogin();
                ar.Show();
                this.Hide();
            }
            else
            {
                this.Activate();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
