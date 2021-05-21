
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
using System.Diagnostics;
namespace NewWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String connection = "server=NZXT\\SQLEXPRESS;database=302;UID=isohrob;password=";
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                int uid = countRows() + 1;
                string name = nameTextBox.Text;
                int age = (int)ageUpDown.Value;
                int weight = (int)weightUpDown.Value;
                int height = (int)heightUpDown.Value;
                int gender = 0;

                if (maleRadioButton.Checked)
                {
                    gender = 0;
                } else
                {
                    gender = 1;
                }
                int activity = (int)ActivityUpDown.Value;
                cmd.CommandText = $"INSERT Users (UserID, Name, Age, Weight, Height, Gender, Activity) VALUES ({uid}, {name}, {age}, {weight}, {height}, {gender}, {activity})";
                //cmd.CommandText = "INSERT Users (UserID, Name, Age, Weight, Height, Gender, Activity) VALUES (1, 'Sohrob Ibrahimi', 21, 152, 70, 'M', 3)";
                cmd.Connection = con;
                
                

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Data submitted!");

                con.Close();
                this.Hide();
                var m = new Form2();
                m.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            
        }
        public int countRows()
        {
            
            string stmt = "SELECT COUNT(*) FROM Users";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection("server=NZXT\\SQLEXPRESS;database=302;UID=isohrob;password="))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Debug.Print("Show window");
            var m = new Form2();
            m.Show();
            this.Hide();
        }
    }
}
