using Metro_Rail_Ticket_Management.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Rail_Ticket_Management
{
    public partial class AdminDashboard : Form
    {
        private string userid;
        public AdminDashboard(string uid)
        {
            InitializeComponent();
            this.userid = uid;
            date.MinDate = DateTime.Today;
            
        }

        

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            //Nothing to do
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            AdminAddTrain adminAddTrain = new AdminAddTrain(userid);
            adminAddTrain.Show();
            this.Hide();
        }

        private void timeTable_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeTable_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nibirProjectDataSet.trains' table. You can move, or remove it, as needed.
            this.trainsTableAdapter.Fill(this.nibirProjectDataSet.trains);

        }

        private void searchTrainBtn_Click(object sender, EventArgs e)
        {
            string trainName = trainCombo.SelectedValue.ToString();
            string dateString = date.Value.ToString("yyyy-MM-dd");
            string timeString = timeTable.Value.ToString("HH:mm:ss");
            /*MessageBox.Show(trainName + "\n" + dateString + "\n" + timeString);*/
            AdminSearchDashboard adminSearchDashboard = new AdminSearchDashboard(userid,trainName, dateString, timeString);
            adminSearchDashboard.Show();
            this.Hide();
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            AdminAddSchedule adminAddSchedule = new AdminAddSchedule(userid);
            adminAddSchedule.Show();
            this.Hide();

        }
    }
}
