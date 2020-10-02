using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Metro_Rail_Ticket_Management.Repository;
using System.IO;

namespace Metro_Rail_Ticket_Management
{
    public partial class UserDashboard : Form
    {
        private string userid;
        public UserDashboard(string uId)
        {
            InitializeComponent();
            this.userid = uId;
            this.getDashBoardData();
        }
        public void getDashBoardData()
        {
            UserdashboardRepo userDashRepo = new UserdashboardRepo();
            SqlDataAdapter sqlDataAdapter = userDashRepo.getDashboardData(userid);
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                try
                {
                    
                    MessageBox.Show("Metro Rail Ticket Management System\n\nDate :" + dataGridView1.Rows[e.RowIndex].Cells[3].Value + "\nDeparture : " + dataGridView1.Rows[e.RowIndex].Cells[1].Value + "\nDestination : " + dataGridView1.Rows[e.RowIndex].Cells[2].Value + "\nTime :" + dataGridView1.Rows[e.RowIndex].Cells[4].Value + "\tSeat : " + dataGridView1.Rows[e.RowIndex].Cells[5].Value + "\nClass: " + dataGridView1.Rows[e.RowIndex].Cells[6].Value + "\nFare : " + dataGridView1.Rows[e.RowIndex].Cells[7].Value+"\n\n\tTicket Printed !\n\n");
                    UserdashboardRepo userdashboardRepo = new UserdashboardRepo();
                    userdashboardRepo.deleteTicket(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.getDashBoardData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
           
            
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            //We are already here. Nothing to do
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchTrain searchTrain = new SearchTrain(userid);
            searchTrain.Show();
            this.Hide();
        }
    }
}
