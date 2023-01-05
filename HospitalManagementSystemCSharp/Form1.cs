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

namespace HospitalManagementSystemCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cutTime.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cutTime.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            if (textBox1.Text == "admin" && textBox2.Text == "pass")
            {
                MessageBox.Show("Welcome Admin. You are logged in successfully.");
                this.Visible = false;
                Home obj1 = new Home();
                obj1.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid username or password please try again.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
