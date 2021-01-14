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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
          
            InitializeComponent();
           
        }
        private Exception ArgumentException()
        {
            throw new NotImplementedException();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainboard f1 = new mainboard();
            f1.ShowDialog();
            this.Close();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" +
            DBConnect.SERVER + ";" + "DATABASE=" +
            DBConnect.DATABASE_NAME + ";" + "UID=" +
            DBConnect.USER_NAME + ";" + "PASSWORD=" +
            DBConnect.PASSWORD + ";" + "SslMode=" +
            DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            {
                string query = "SELECT max(cast(userid as signed))+1 as `newID` from users"; 
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                sqlDA.Fill(DS);
                //tbuserid.Text = DS.Tables[0].Rows[0][0].ToString();
                tbuserid.Text = Convert.ToString(DS.Tables[0].Rows[0][0].ToString());
            }
            
            tbuserid.Enabled = false;
            cbgender.Items.Add("Female");
            cbgender.Items.Add("Male");
            cbgender.Items.Add("Unspecified");
            cbgender.DropDownStyle= System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbrelationshipstatus.Items.Add("Single");
            cbrelationshipstatus.Items.Add("Engaged");
            cbrelationshipstatus.Items.Add("Married");
            cbrelationshipstatus.Items.Add("It's Complicated");
            cbrelationshipstatus.DropDownStyle= System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            

            try {

            {
                String query =
            //"INSERT into users (UserID,FirstName,LastName,Gender,HomeTown,HomeCity,CurrentTown,CurrentCity,RelationshipStatus) " +
            //  "VALUE ('" + "@prm_UserID" + "','" + "@prm_FirstName" + "','" + "@prm_LastName" + "','" + "@prm_Gender" + "','" + "@prm_HomeTown" + "','" + "@prm_HomeCity" + "','" + "@prm_CurrentTown" + "','" + "@prm_CurrentCity" + "','" + "@prm_RelationshipStatus" + "');";
            "INSERT into users (UserID,FirstName,LastName,Gender,HomeTown,HomeCity,CurrentTown,CurrentCity,RelationshipStatus) " +
            "VALUE (@prm_UserID,@prm_FirstName,@prm_LastName,@prm_Gender,@prm_HomeTown,@prm_HomeCity,@prm_CurrentTown,@prm_CurrentCity,@prm_RelationshipStatus);";

                myConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query,myConnection);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);

                //TODO: Change my arbitrary "80" to actual Stock fields' sizes! 
                cmd.Parameters.AddWithValue("@prm_UserID", tbuserid.Text);
                cmd.Parameters.AddWithValue("@prm_FirstName", tbfirstname.Text);
                cmd.Parameters.AddWithValue("@prm_LastName",tblastname.Text);
                cmd.Parameters.AddWithValue("@prm_Gender",cbgender.Text);
                cmd.Parameters.AddWithValue("@prm_HomeTown",tbhometown.Text);
                cmd.Parameters.AddWithValue("@prm_HomeCity", tbhomecity.Text);
                cmd.Parameters.AddWithValue("@prm_CurrentTown", tbcurrenttown.Text);
                cmd.Parameters.AddWithValue("@prm_CurrentCity", tbcurrentcity.Text);
                cmd.Parameters.AddWithValue("@prm_RelationshipStatus", cbrelationshipstatus.Text);

                //cmd.Parameters.Add("@prm_UserID", MySqlDbType.VarChar,10).Value = tbuserid.Text;
                //cmd.Parameters.Add("@prm_FirstName", MySqlDbType.VarChar, 55).Value = tbfirstname.Text;
                //cmd.Parameters.Add("@prm_LastName", MySqlDbType.VarChar, 55).Value = tblastname.Text;
                //cmd.Parameters.Add("@prm_Gender", MySqlDbType.VarChar, 15).Value = cbgender.Text;
                //cmd.Parameters.Add("@prm_HomeTown", MySqlDbType.VarChar, 65).Value = tbhometown.Text;
                //cmd.Parameters.Add("@prm_HomeCity", MySqlDbType.VarChar, 60).Value = tbhomecity.Text;
                //cmd.Parameters.Add("@prm_CurrentTown", MySqlDbType.VarChar, 65).Value = tbcurrenttown.Text;
                //cmd.Parameters.Add("@prm_CurrentCity", MySqlDbType.VarChar, 60).Value = tbcurrentcity.Text;
                //cmd.Parameters.Add("@prm_RelationshipStatus", MySqlDbType.VarChar, 20).Value = cbrelationshipstatus.Text;
                cmd.ExecuteNonQuery();
                    
                }
                MessageBox.Show("User " + tbuserid.Text + " added!");    
            } 
                catch (Exception)
            {
                MessageBox.Show("User Not Added, Please try again");
             
            }
        }
        }
    }

