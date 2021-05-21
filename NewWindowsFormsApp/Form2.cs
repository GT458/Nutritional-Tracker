using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
namespace NewWindowsFormsApp
{
    public partial class Form2 : Form
    {
        public string constr = "server=NZXT\\SQLEXPRESS;database=302;UID=isohrob;password=";
        private int selectedUID = 1;
        public Form2()
        { 
            Form2_Load();
        }
        
        private void Form2_Load()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT UserID, Name FROM Users", con))
                {
                    // 0 = Name, 1 = FoodID, 2 = Calories, 3 = Carbs, 4 = Protein, 5 = Fat, 6 = Cholesterol
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                   
                    foreach (DataRow row in dt.Rows)
                    {
                        
                        ListViewItem item = new ListViewItem(row["Name"].ToString());
                        item.SubItems.Add(row["UserID"].ToString());
                        listViewUsers.Items.Add(item);
                    }

                    listViewUsers.View = View.List;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Item selected");
            ListView.SelectedListViewItemCollection user = this.listViewUsers.SelectedItems;
            foreach (ListViewItem item in user)
            {

                populateStatsLabels(Int32.Parse(item.SubItems[1].Text));
                selectedUID = Int32.Parse(item.SubItems[1].Text);
            }                                                                                                                                                                        
            
        }

        private void populateStatsLabels(int id)
        {
            string query = $"SELECT * FROM Users WHERE UserID = {id}";
            using (SqlConnection connection = new SqlConnection(constr))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable userTable = new DataTable();
                adapter.Fill(userTable);
                ageLabel.Text = "Age: " + userTable.Rows[0]["Age"].ToString();
                weightLabel.Text = "Weight: " + userTable.Rows[0]["Weight"].ToString();
                heightLabel.Text = "Height: " + userTable.Rows[0]["Height"].ToString();
                string gender = userTable.Rows[0]["Gender"].ToString();
                string activityLevel = userTable.Rows[0]["Activity"].ToString();
                switch (gender)
                {
                    case "0":
                        genderLabel.Text = "Gender: Male";
                        break;
                    case "1":
                        genderLabel.Text = "Gender: Female";
                        break;
                    default:
                        genderLabel.Text = "Not Listed";
                        break;
                }
                switch (activityLevel)
                {
                    case "0":
                        activityLabel.Text = "Activity Level: Sedentary";
                        break;
                    case "1":
                        activityLabel.Text = "Activity Level: Lightly Active";
                        break;
                    case "2":
                        activityLabel.Text = "Activity Level: Moderately Active";
                        break;
                    case "3":
                        activityLabel.Text = "Activity Level: Very Active";
                        break;
                    default:
                        activityLabel.Text = "Activity Level: Sedentary";
                        break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Form1();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new Form3(selectedUID);
            m.Show();
            this.Hide();
        }
    }
}
