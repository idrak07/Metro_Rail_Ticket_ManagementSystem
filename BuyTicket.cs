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
    public partial class BuyTicket : Form
    {
        private string userid,classId, depart, dest, date, time, cl;
        private int totalFare;

        private void rocketMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (paymentCombo.SelectedItem.ToString() == null)
            {
                bkashPayment.Visible = false;
                rocketPayment.Visible = false;
                visapayment.Visible = false;
            }
            else if (paymentCombo.SelectedItem.ToString()== "Rocket")
            {
                totalFare = fare * seat;
                rocketFare.Text = totalFare.ToString();
                rocketPayment.Visible = true;
                bkashPayment.Visible = false;
                visapayment.Visible = false;
            }
            else if(paymentCombo.SelectedItem.ToString()== "Bkash")
            {
                totalFare = fare * seat;
                bkashFare.Text = totalFare.ToString();
                bkashPayment.Visible = true;
                rocketPayment.Visible = false;
                visapayment.Visible = false;
            }
            else if(paymentCombo.SelectedItem.ToString()== "Visa")
            {
                totalFare = fare * seat;
                visaFare.Text = totalFare.ToString();
                bkashPayment.Visible = false;
                rocketPayment.Visible = false;
                visapayment.Visible = true;
            }
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void visaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(visaBox.Text+"\t"+totalFare.ToString());

        }

        private void bkashBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void rocketBtn_Click(object sender, EventArgs e)
        {

        }

        private void visaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private int seat,fare;
        public BuyTicket(string uid, string cid, int s,string depart, string dest, string date, string time, string cl,int fare)
        {
            InitializeComponent();
            this.userid = uid;
            this.classId = cid;
            this.seat = s;
            label13.Text = seat.ToString();
            this.depart = depart;
            label8.Text = depart;
            this.dest = dest;
            label9.Text = dest;
            this.date = date;
            label10.Text = date;
            this.time = time;
            label11.Text = time;
            this.cl = cl;
            label12.Text = cl;
            this.fare = fare;

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(userid);
            userDashboard.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchTrain searchTrain = new SearchTrain(userid);
            searchTrain.Show();
            this.Hide();
        }
    }
}
