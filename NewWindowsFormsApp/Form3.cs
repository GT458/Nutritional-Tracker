using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NewWindowsFormsApp
{
    public partial class Form3 : Form
    {
        public string constr = "server=NZXT\\SQLEXPRESS;database=302;UID=isohrob;password=";
        private int uid = 1;
        private Person myUser;
        private int caloriesNeeded;
        private int carbsNeeded;
        private int proteinNeeded;
        private int fatNeeded;
        private int cholesterolNeeded = 300;

        private int currentCalories = 0;
        private int currentCarbs = 0;
        private int currentProtein = 0;
        private int currentFat = 0;
        private int currentCholesterol = 0;
        public Form3()
        {
            InitializeComponent();
            Form3_Load();
        }
        public Form3(int inUID)
        {
            InitializeComponent();
            Form3_Load();
            this.uid = inUID;
        }
        private void Form3_Load()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT FoodID, Name, Calories, Carbohydrates, Protein, Fat, Cholesterol FROM food", con))
                {

                    DataTable dt = new DataTable();
                    sda.Fill(dt);


                    foreach (DataRow row in dt.Rows)
                    {
                        // 0 = Name, 1 = FoodID, 2 = Calories, 3 = Carbs, 4 = Protein, 5 = Fat, 6 = Cholesterol
                        ListViewItem item = new ListViewItem(row["Name"].ToString());
                        item.SubItems.Add(row["FoodID"].ToString());
                        item.SubItems.Add(row["Calories"].ToString());
                        item.SubItems.Add(row["Carbohydrates"].ToString());
                        item.SubItems.Add(row["Protein"].ToString());
                        item.SubItems.Add(row["Fat"].ToString());
                        item.SubItems.Add(row["Cholesterol"].ToString());
                        listViewFood.Items.Add(item);
                    }

                    listViewFood.View = View.List;
                }
                string query = $"SELECT * FROM Users WHERE UserID = {uid}";
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable userTable = new DataTable();
                    adapter.Fill(userTable);
                    myUser = new Person(userTable.Rows[0]["Name"].ToString(), uid, Convert.ToInt32(userTable.Rows[0]["Age"]), Convert.ToInt32(userTable.Rows[0]["Weight"]), Convert.ToInt32(userTable.Rows[0]["Height"]), Convert.ToInt32(userTable.Rows[0]["Activity"]), Convert.ToInt32(userTable.Rows[0]["Gender"]));
                    populateNutritionLabels();
                }
                
            }
        }

        private void populateNutritionLabels()
        {
            double activityLevel;
            int currentLevel = myUser.getActivity();
            switch (currentLevel)
            {
                case 0:
                    activityLevel = 1.2;
                    break;
                case 1:
                    activityLevel = 1.375;
                    break;
                case 2:
                    activityLevel = 1.55;
                    break;
                case 3:
                    activityLevel = 1.725;
                    break;
                default:
                    activityLevel = 1.2;
                    break;
            }
            switch(myUser.getGender())
            {
                case 0:
                    caloriesNeeded = (int)(((66 + (6.3 * myUser.getWeight()) + 12.9 * myUser.getHeight() - 6.8 * myUser.getAge())) * activityLevel);
                    break;
                case 1:
                    caloriesNeeded = ((int)(((655 + (4.3 * myUser.getWeight()) + 4.7 * myUser.getHeight() - 4.7 * myUser.getAge())) * activityLevel));
                    break;
                default:
                    caloriesNeeded = ((int)(((66 + (6.3 * myUser.getWeight()) + 12.9 * myUser.getHeight() - 6.8 * myUser.getAge())) * activityLevel));
                    break;
            }
            carbsNeeded = (int)((int)caloriesNeeded * .45)/4;
            proteinNeeded = (int)((int)caloriesNeeded * .35)/4;
            fatNeeded = (int)((int)caloriesNeeded * .20)/9;

            caloriesLabel.Text = "Calories: " + currentCalories + "/" + caloriesNeeded;
            carbsLabel.Text = "Carbohydrates: " + currentCarbs + "/" + carbsNeeded;
            proteinLabel.Text = "Protein: " + currentProtein + "/" + proteinNeeded;
            fatLabel.Text = "Fat: " + currentFat + "/" + fatNeeded;
            cholesterolLabel.Text = "Cholesterol: " + currentCholesterol + "/" + cholesterolNeeded;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new Form1();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection food = this.listViewFood.SelectedItems;
            foreach (ListViewItem item in food)
            {
                updateNutritionLabels(item);
            }
        }

        private void updateNutritionLabels(ListViewItem item)
        {
            currentCalories += int.Parse(item.SubItems[2].Text);
            currentCarbs += int.Parse(item.SubItems[3].Text);
            currentProtein += int.Parse(item.SubItems[4].Text);
            currentFat += int.Parse(item.SubItems[5].Text);
            currentCholesterol += int.Parse(item.SubItems[6].Text);


            caloriesLabel.Text = "Calories: " + currentCalories + "/" + caloriesNeeded.ToString();
            carbsLabel.Text = "Carbohydrates: " + currentCarbs + "/" + carbsNeeded.ToString();
            proteinLabel.Text = "Protein: " + currentProtein + "/" + proteinNeeded.ToString();
            fatLabel.Text = "Fat: " + currentFat + "/" + fatNeeded;
            cholesterolLabel.Text = "Cholesterol: " + currentCholesterol + "/" + cholesterolNeeded.ToString();

            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                //cmd.CommandText = $"INSERT INTO UserStats (UID, Calories, Carbohydrates, Protein, Fat, Cholesterol) VALUES ({uid}, {currentCalories}, {currentCarbs}, {currentProtein}, {currentFat}, {currentCholesterol}) ON DUPLICATE KEY UPDATE Calories+={currentCalories}, Carbohydrates+={currentCarbs}, Protein += {currentProtein}, Fat += {currentFat}, Cholesterol += {currentCholesterol}";
                cmd.CommandText = $"UPDATE UserStats SET Calories+={currentCalories}, Carbohydrates+={currentCarbs}, Protein += {currentProtein}, Fat += {currentFat}, Cholesterol += {currentCholesterol} WHERE UID = {uid} IF @@ROWCOUNT = 0 INSERT INTO UserStats (UID, Calories, Carbohydrates, Protein, Fat, Cholesterol) VALUES ({uid}, {currentCalories}, {currentCarbs}, {currentProtein}, {currentFat}, {currentCholesterol})";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Food Data to Database UserStats!");
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        
    }
}
