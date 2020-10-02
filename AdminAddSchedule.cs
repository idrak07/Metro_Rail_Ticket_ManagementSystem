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
    public partial class AdminAddSchedule : Form
    {
        private string userid;
        public AdminAddSchedule(string uid)
        {
            InitializeComponent();
            this.userid = uid;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void fareBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addScheduleBtn_Click(object sender, EventArgs e)
        {
            string trainNameValue = trainCombo.SelectedValue.ToString();
            string dateValue = date.Value.ToString("yyyy-MM-dd");
            string timevalue = timeTable.Value.ToString("HH:mm:ss");
            string classValue = classBox.SelectedItem.ToString();
            string departureValue = departureBox.SelectedItem.ToString();
            string destinationvalue = destinationBox.SelectedItem.ToString();
            string farevalue = fareBox.Text;

            AdminAddScheduleRepo adminAddScheduleRepo = new AdminAddScheduleRepo();
            adminAddScheduleRepo.addTrain(classValue, "100", farevalue, "100", trainNameValue, dateValue, timevalue, departureValue, destinationvalue);
            MessageBox.Show("Schedule Added");
            AdminDashboard adminDashboard = new AdminDashboard(userid);
            adminDashboard.Show();
            this.Hide();
        }

        private void AdminAddSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nibirProjectDataSet.trains' table. You can move, or remove it, as needed.
            this.trainsTableAdapter.Fill(this.nibirProjectDataSet.trains);

        }
    }
}
