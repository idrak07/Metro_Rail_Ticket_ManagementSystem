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
    public partial class AdminSearchDashboard : Form
    {
        private string userid, searchTrainName, searchDate, searchTime;
        DataTable dataTable = new DataTable();

        private void searchDash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                //MessageBox.Show("Seat " + dataTable.Rows[e.RowIndex][4]+"\nAvailable seat "+ dataTable.Rows[e.RowIndex][6]);
                if (Convert.ToInt32(dataTable.Rows[e.RowIndex][4].ToString()) == Convert.ToInt32(dataTable.Rows[e.RowIndex][6].ToString()))
                {
                    AdminSearchDashRepo adminSearchDashRepo = new AdminSearchDashRepo();
                    adminSearchDashRepo.deleteSchedule(Convert.ToInt32(dataTable.Rows[e.RowIndex][0].ToString()));
                    MessageBox.Show(" Train Schedule has been deleted !");
                    this.getDashBoardData();

                }
                else
                {
                    MessageBox.Show("\tMetro Rail Ticket manageent System\n\n Schedule can't be deleted ! \n Minimum 1 ticket has been sold ! ");
                }

            }
        }

        public AdminSearchDashboard(string userid, string searchTrainName, string searchDate, string searchTime)
        {
            InitializeComponent();
            this.userid = userid;
            this.searchTrainName = searchTrainName;
            this.searchDate = searchDate;
            this.searchTime = searchTime;
            this.getDashBoardData();
            searchDash.Refresh();
        }
        public void getDashBoardData()
        {
            AdminSearchDashRepo adminSearchDashRepo = new AdminSearchDashRepo();
            SqlDataAdapter sqlDataAdapter = adminSearchDashRepo.getSearchDash(searchTrainName, searchDate, searchTime);



            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {

                searchDash.AutoGenerateColumns = false;
                searchDash.DataSource = dataTable;
                searchDash.Refresh();
            }
            else
            {
                searchDash.Visible = false;
                notfoundLabel.Visible = true;
            }
            /*searchDash.AutoGenerateColumns = false;
            searchDash.DataSource = ds;
            searchDash.Refresh();*/

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}
