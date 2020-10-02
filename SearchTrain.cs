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
    public partial class SearchTrain : Form
    {
        private string userid;
        public SearchTrain(string uId)
        {
            InitializeComponent();
            this.userid = uId;
            date.MinDate = DateTime.Today;
        }

        

        private void dashBtn_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(userid);
            userDashboard.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //We are here already
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string departure = departureBox.SelectedItem.ToString();
            string destination = destinationCombo.SelectedItem.ToString();
            string d = date.Value.ToString("yyyy-MM-dd");
            int s = Convert.ToInt32(seatCombo.SelectedItem.ToString());

            SearchTrainDashboard searchTrainDashboard = new SearchTrainDashboard(userid, departure, destination, d,s);
            searchTrainDashboard.Show();
            this.Hide();

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}
