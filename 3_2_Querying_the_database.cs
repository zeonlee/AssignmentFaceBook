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

namespace AssignmentFaceBook
{
    public partial class Querying_Database : Form
    {
        public Querying_Database()
        {
            InitializeComponent();
            comboBox1.Items.Add("List the users with the largest number of friends(sorted by number of friends).");
            comboBox1.Items.Add("List the users whose user ID is a multiple of 985 (sorted by user ID).");
            comboBox1.Items.Add("List the male users (sorted alphabetically by first name).");
            comboBox1.Items.Add("List the female users whose user ID is a multiple of 985 (sorted by ID). ");
            comboBox1.Items.Add("List the male users whose user ID is a multiple of 985 (sorted alphabetically by last name). ");
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string connectionString = "SERVER=" +
            DBConnect.SERVER + ";" + "DATABASE=" +
            DBConnect.DATABASE_NAME + ";" + "UID=" +
            DBConnect.USER_NAME + ";" + "PASSWORD=" +
            DBConnect.PASSWORD + ";" + "SslMode=" +
            DBConnect.SslMode + ";"+"Convert Zero Datetime = True";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            
            if (comboBox1.SelectedIndex == 0)
                
            {
                string query = "SELECT count(t2.FriendsUserID) as `Num of friends`, t1.UserID, t1.FirstName, t1.LastName, t1.Gender, t1.HomeTown, t1.HomeCity, t1.CurrentTown, t1.CurrentCity, t1.RelationshipStatus " +
                    "FROM users t1 " +
                    "LEFT JOIN friendships t2 on t1.userid = t2.userid " +
                    "Group by UserID " +
                    "ORDER BY `Num of friends` DESC;";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable DataTable = new DataTable();
                sqlDA.Fill(DataTable);
                dataGridView1.DataSource = DataTable;
              
            }
            
            else if (comboBox1.SelectedIndex == 1)
            {
                string query = "SELECT (t1.UserID/985) as `UserID Multiple of 985`, count(t2.FriendsUserID) as `Num of friends`, t1.UserID, t1.FirstName, t1.LastName, t1.Gender, t1.HomeTown, t1.HomeCity, t1.CurrentTown, t1.CurrentCity, t1.RelationshipStatus " +
                    "FROM users t1 " +
                    "LEFT JOIN friendships t2 on t1.userid = t2.userid " +
                    "WHERE (t1.UserID/985) not like '%.%'" +
                    "Group by UserID " +
                    "ORDER BY t1.userid+0 ASC;";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable aDataTable = new DataTable();
                sqlDA.Fill(aDataTable);
                dataGridView1.DataSource = aDataTable;
    
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                string query = "SELECT count(t2.FriendsUserID) as `Num of friends`, t1.UserID, t1.FirstName, t1.LastName, t1.Gender, t1.HomeTown, t1.HomeCity, t1.CurrentTown, t1.CurrentCity, t1.RelationshipStatus " +
                    "FROM users t1 " +
                    "LEFT JOIN friendships t2 on t1.userid = t2.userid " +
                    "WHERE t1.gender = 'male' "+
                    "Group by UserID " +
                    "ORDER BY t1.firstname ASC, t1.userid+0 ASC;";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable bDataTable = new DataTable();
                sqlDA.Fill(bDataTable);
                dataGridView1.DataSource = bDataTable;
      
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                string query = "SELECT (t1.UserID/985) as `UserID Multiple of 985`, count(t2.FriendsUserID) as `Num of friends`, t1.UserID, t1.FirstName, t1.LastName, t1.Gender, t1.HomeTown, t1.HomeCity, t1.CurrentTown, t1.CurrentCity, t1.RelationshipStatus " +
                    "FROM users t1 " +
                    "LEFT JOIN friendships t2 on t1.userid = t2.userid " +
                    "WHERE (t1.UserID/985) not like '%.%' and t1.gender = 'female' "+
                    "Group by UserID " +
                    "ORDER BY t1.userid+0 ASC;";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable cDataTable = new DataTable();
                sqlDA.Fill(cDataTable);
                dataGridView1.DataSource = cDataTable;

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                string query = "SELECT (t1.UserID/985) as `UserID Multiple of 985`, count(t2.FriendsUserID) as `Num of friends`, t1.UserID, t1.FirstName, t1.LastName, t1.Gender, t1.HomeTown, t1.HomeCity, t1.CurrentTown, t1.CurrentCity, t1.RelationshipStatus " +
                    "FROM users t1 " +
                    "LEFT JOIN friendships t2 on t1.userid = t2.userid " +
                    "WHERE (t1.UserID/985) not like '%.%' and t1.gender = 'male' " +
                    "Group by UserID " +
                    "ORDER BY t1.lastname ASC, t1.userid+0 ASC;";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable cDataTable = new DataTable();
                sqlDA.Fill(cDataTable);
                dataGridView1.DataSource = cDataTable;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        
            {
                this.Hide();
                mainboard f1 = new mainboard();
                f1.ShowDialog();
                this.Close();
            }

        private void Querying_Database_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        }
    }
}
