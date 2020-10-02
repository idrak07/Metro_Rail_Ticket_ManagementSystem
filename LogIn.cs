using Metro_Rail_Ticket_Management.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Rail_Ticket_Management
{
    public partial class LogIn : Form
    {
        public static string userid;
        public static int usertype = 0;
        public LogIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void userId_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userId = userIdBox.Text;
            string password = passTextBox.Text;
            UserLogin userLogin = new UserLogin();
            int flag = userLogin.getLoginInfo(userId, password);
            if (flag == 1)
            {
                UserDashboard dashboard = new UserDashboard(userId);
                dashboard.Show();
                this.Hide();
            }
            else if (flag == 2)
            {
                AdminDashboard adminDashboard = new AdminDashboard(userid);
                adminDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password");
            }

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
