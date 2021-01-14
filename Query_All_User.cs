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
    public partial class Query_All_User : Form
    {
        public Query_All_User()
        {
            InitializeComponent();
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
            {
                string query = "SELECT * from users;";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable usersDataTable = new DataTable();
                sqlDA.Fill(usersDataTable);
                dataGridView1.DataSource = usersDataTable;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainboard f1 = new mainboard();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" +
            DBConnect.SERVER + ";" + "DATABASE=" +
            DBConnect.DATABASE_NAME + ";" + "UID=" +
            DBConnect.USER_NAME + ";" + "PASSWORD=" +
            DBConnect.PASSWORD + ";" + "SslMode=" +
            DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            {
                string query = "SELECT * from users where firstname like '%" + textBox1.Text + "%'";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable usersDataTable = new DataTable();
                sqlDA.Fill(usersDataTable);
                dataGridView1.DataSource = usersDataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" +
DBConnect.SERVER + ";" + "DATABASE=" +
DBConnect.DATABASE_NAME + ";" + "UID=" +
DBConnect.USER_NAME + ";" + "PASSWORD=" +
DBConnect.PASSWORD + ";" + "SslMode=" +
DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            {
                string query = "SELECT * from users where lastname like '%" + textBox2.Text + "%'";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable usersDataTable = new DataTable();
                sqlDA.Fill(usersDataTable);
                dataGridView1.DataSource = usersDataTable;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" +
DBConnect.SERVER + ";" + "DATABASE=" +
DBConnect.DATABASE_NAME + ";" + "UID=" +
DBConnect.USER_NAME + ";" + "PASSWORD=" +
DBConnect.PASSWORD + ";" + "SslMode=" +
DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            {
                string query = "SELECT * from users where hometown like '%" + textBox3.Text + "%'";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable usersDataTable = new DataTable();
                sqlDA.Fill(usersDataTable);
                dataGridView1.DataSource = usersDataTable;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" +
DBConnect.SERVER + ";" + "DATABASE=" +
DBConnect.DATABASE_NAME + ";" + "UID=" +
DBConnect.USER_NAME + ";" + "PASSWORD=" +
DBConnect.PASSWORD + ";" + "SslMode=" +
DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            {
                string query = "SELECT * from users where CurrentCity like '%" + textBox4.Text + "%'";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable usersDataTable = new DataTable();
                sqlDA.Fill(usersDataTable);
                dataGridView1.DataSource = usersDataTable;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" +
DBConnect.SERVER + ";" + "DATABASE=" +
DBConnect.DATABASE_NAME + ";" + "UID=" +
DBConnect.USER_NAME + ";" + "PASSWORD=" +
DBConnect.PASSWORD + ";" + "SslMode=" +
DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            {
                string query = "SELECT * from users where Gender like '%" + textBox5.Text + "%'";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable usersDataTable = new DataTable();
                sqlDA.Fill(usersDataTable);
                dataGridView1.DataSource = usersDataTable;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" +
DBConnect.SERVER + ";" + "DATABASE=" +
DBConnect.DATABASE_NAME + ";" + "UID=" +
DBConnect.USER_NAME + ";" + "PASSWORD=" +
DBConnect.PASSWORD + ";" + "SslMode=" +
DBConnect.SslMode + ";";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            {
                string query = "SELECT * from users where userID like '%" + textBox6.Text + "%'";
                myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable usersDataTable = new DataTable();
                sqlDA.Fill(usersDataTable);
                dataGridView1.DataSource = usersDataTable;
            }
        }

        private void Query_All_User_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        }
    }
}
