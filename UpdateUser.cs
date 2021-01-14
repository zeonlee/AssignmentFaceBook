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
    public partial class UpdateUser : Form
    {


        public UpdateUser()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainboard f1 = new mainboard();
            f1.ShowDialog();
            this.Close();
        }
        private Exception ArgumentException()
        {
            throw new NotImplementedException();
        }

        private void UpdateUser_Load(object sender, EventArgs e)


        
        {

            SplashScreen1.ShowSplashScreen();


            string connectionString = "SERVER=" +
            DBConnect.SERVER + ";" + "DATABASE=" +
            DBConnect.DATABASE_NAME + ";" + "UID=" +
            DBConnect.USER_NAME + ";" + "PASSWORD=" +
            DBConnect.PASSWORD + ";" + "SslMode=" +
            DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            
                string query = "SELECT * from Users";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable DS = new DataTable();
                sqlDA.Fill(DS);
                DS.Columns.Add("SearchUserName");
                foreach (DataRow item in DS.Rows)
                {
                item["SearchUserName"] = item["FirstName"] + "," + item["LastName"] + "," + item["UserID"] + "," + item["Gender"] + "," + item["RelationshipStatus"];
                }
        
            cbsearchuser.DisplayMember = "SearchUserName";
            cbsearchuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbsearchuser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbsearchuser.DataSource = DS;
            cbsearchuser.AutoCompleteSource = AutoCompleteSource.ListItems;

            tbuserid.Enabled = false;
            cbgender.Items.Add("Female");
            cbgender.Items.Add("Male");
            cbgender.Items.Add("Unspecified");
            cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbrelationshipstatus.Items.Add("Single");
            cbrelationshipstatus.Items.Add("Engaged");
            cbrelationshipstatus.Items.Add("Married");
            cbrelationshipstatus.Items.Add("It's Complicated");
            cbrelationshipstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            
            SplashScreen1.CloseForm();

        }

        private void cbsearchuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbuserid.Text = cbsearchuser.Text.Split(',')[2];
            string connectionString = "SERVER=" +
            DBConnect.SERVER + ";" + "DATABASE=" +
            DBConnect.DATABASE_NAME + ";" + "UID=" +
            DBConnect.USER_NAME + ";" + "PASSWORD=" +
            DBConnect.PASSWORD + ";" + "SslMode=" +
            DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            {
                string query = "SELECT * from users where UserID = '" + tbuserid.Text + "'";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
            
                    while (dr.Read())
                    {
                        tbfirstname.Text = (string)(dr["FirstName"] ?? "").ToString();
                        tblastname.Text = (string)(dr["LastName"] ?? "").ToString();
                        cbgender.Text = (string)(dr["Gender"] ?? "").ToString();
                        tbhometown.Text = (string)(dr["HomeTown"] ?? "").ToString();
                        tbhomecity.Text = (string)(dr["HomeCity"] ?? "").ToString();
                        tbcurrenttown.Text = (string)(dr["CurrentTown"] ?? "").ToString();
                        tbcurrentcity.Text = (string)(dr["CurrentCity"] ?? "").ToString();
                        cbrelationshipstatus.Text = (string)(dr["RelationshipStatus"] ?? "").ToString();
                        }

                    dr.Close();
                }
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" +
            DBConnect.SERVER + ";" + "DATABASE=" +
            DBConnect.DATABASE_NAME + ";" + "UID=" +
            DBConnect.USER_NAME + ";" + "PASSWORD=" +
            DBConnect.PASSWORD + ";" + "SslMode=" +
            DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            try
            {

                {
                    String query =
                "UPDATE users SET Firstname = @prm_FirstName, LastName = @prm_LastName, Gender = @prm_Gender, HomeTown = @prm_HomeTown, HomeCity = @prm_HomeCity, CurrentTown = @prm_CurrentTown, CurrentCity = @prm_CurrentCity, RelationshipStatus = @prm_RelationshipStatus " +
                "WHERE UserID = " + tbuserid.Text + "";

                    myConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, myConnection);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);

                    
                    cmd.Parameters.AddWithValue("@prm_FirstName", tbfirstname.Text);
                    cmd.Parameters.AddWithValue("@prm_LastName", tblastname.Text);
                    cmd.Parameters.AddWithValue("@prm_Gender", cbgender.Text);
                    cmd.Parameters.AddWithValue("@prm_HomeTown", tbhometown.Text);
                    cmd.Parameters.AddWithValue("@prm_HomeCity", tbhomecity.Text);
                    cmd.Parameters.AddWithValue("@prm_CurrentTown", tbcurrenttown.Text);
                    cmd.Parameters.AddWithValue("@prm_CurrentCity", tbcurrentcity.Text);
                    cmd.Parameters.AddWithValue("@prm_RelationshipStatus", cbrelationshipstatus.Text);

                    
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("User " + tbuserid.Text + " updated!");
                this.Hide();
                UpdateUser f1 = new UpdateUser();
                f1.ShowDialog();
                this.Close();

            }
            catch (Exception)
            {
            MessageBox.Show("User not updated, Please try again");

            }
        }
    }
    }

