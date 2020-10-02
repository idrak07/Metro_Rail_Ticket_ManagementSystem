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
    public partial class AdminAddTrain : Form
    {
        private string userid;
        public AdminAddTrain(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            AdminAddTrainRepo adminAddTrainRepo = new AdminAddTrainRepo();
            int trainMax = adminAddTrainRepo.maxTrainId()+1;
            trainIdBox.Text = "metro" + trainMax.ToString().PadLeft(4, '0');
            trainIdBox.Enabled = false;
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(userid);
            adminDashboard.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string trainID = trainIdBox.Text;
            string trainName = trainNameBox.Text;
            AdminAddTrainRepo adminAddTrainRepo = new AdminAddTrainRepo();
            adminAddTrainRepo.addTrain(trainID, trainName);
            MessageBox.Show("Train Added !");
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
