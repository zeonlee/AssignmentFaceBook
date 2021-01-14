using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFaceBook
{
    public partial class mainboard : Form
    {
        public mainboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Query_All_User f1 = new Query_All_User();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f1 = new login();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Querying_Database f1 = new Querying_Database();
            f1.ShowDialog();
            this.Close();
        }

        private void mainboard_Load(object sender, EventArgs e)
        {
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser f1 = new CreateUser();
            f1.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateUser f1 = new UpdateUser();
            f1.ShowDialog();
            this.Close();
     

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser f1 = new DeleteUser();
            f1.ShowDialog();
            this.Close();
        }
    }
}
