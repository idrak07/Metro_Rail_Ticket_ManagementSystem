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
    public partial class SearchTrainDashboard : Form
    {
        private string userid, desti, depart, d;
        private int s;
        private DataTable ds = new DataTable();

        public SearchTrainDashboard(string uid, string dep, string des, string d, int s)
        {
            InitializeComponent();
            this.userid = uid;
            this.depart = dep;
            this.desti = des;
            this.d = d;
            this.s = s;
            this.getDashBoardData();


        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchTrain searchTrain = new SearchTrain(userid);
            searchTrain.Show();
            this.Hide();
        }

        private void searchDash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (Convert.ToInt32(searchDash.Rows[e.RowIndex].Cells[5].Value) < s)
                {
                    MessageBox.Show(" Enough seat Not Available !");
                }
                else
                {
                    string classid = ds.Rows[e.RowIndex]["classId"].ToString();
                    string departure = searchDash.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string destination = searchDash.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string date = searchDash.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string time = searchDash.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string cl = searchDash.Rows[e.RowIndex].Cells[6].Value.ToString();
                    int fare = Convert.ToInt32(searchDash.Rows[e.RowIndex].Cells[7].Value.ToString());
                    BuyTicket buyTicket = new BuyTicket(userid,classid, s, departure, destination, date.Substring(0,10), time, cl, fare);
                    buyTicket.Show();
                    this.Hide();
                }

            }
        }

        

        public void getDashBoardData()
        {
            SearchTrainRepo userDashRepo = new SearchTrainRepo();
            SqlDataAdapter da = userDashRepo.getSearchDash(depart,desti,d);
            
            

            da.Fill(ds);
            if (ds.Rows.Count>0)
            {
                
                searchDash.AutoGenerateColumns = false;
                searchDash.DataSource = ds;
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

        private void dashBtn_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(userid);
            userDashboard.Show();
            this.Hide();
        }
    }
}
