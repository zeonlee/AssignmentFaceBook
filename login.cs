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

    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
       
        }

        private void login_Load(object sender, EventArgs e)
        {
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.Text = ("Server not connected, all menu currently disabled");
            button2.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
            {
            DBConnect.SERVER = textBox1.Text;
            DBConnect.DATABASE_NAME = textBox2.Text;
            DBConnect.USER_NAME = textBox3.Text;
            DBConnect.PASSWORD = textBox4.Text;
            DBConnect.SslMode = "none";

                string connectionString = "SERVER=" +
                     DBConnect.SERVER + ";" + "DATABASE=" +
                     DBConnect.DATABASE_NAME + ";" + "UID=" +
                     DBConnect.USER_NAME + ";" + "PASSWORD=" +
                     DBConnect.PASSWORD + ";" + "SslMode=" +
                     DBConnect.SslMode + ";"+"Convert Zero Datetime = True";

            MySqlConnection myConnection = new MySqlConnection(connectionString);
        
                try
                {
                    myConnection.Open();
                    label1.Text = ("ServerVersion: " + myConnection.ServerVersion +
                    "\nState: " + myConnection.State.ToString()) +
                    "\nMenu buttons enabled";
                button2.Show();

            }
                catch (Exception) { 
                label1.Text = "Please check connection, menu buttons disabled";
                button2.Hide();
            }

            }
            private Exception ArgumentException()
            {
                throw new NotImplementedException();
            }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainboard f1 = new mainboard();
            f1.ShowDialog();
            this.Close();
        }


    }
}