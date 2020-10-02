using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Rail_Ticket_Management.Repository
{
    class UserdashboardRepo
    {
        public SqlDataAdapter getDashboardData(string userid)
        {
            SqlDataAdapter da;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=IDRAK-PC;Initial Catalog=NibirProject;Integrated Security=True");//connection name

                con.Open();

                string sql = "Select * from dashboard where userid='" + userid + "'";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.CommandType = CommandType.Text;

                da = new SqlDataAdapter(cmd);
                
            }
            catch (Exception ex)
            {
                da = new SqlDataAdapter();
                Console.WriteLine("" + ex.Message);
            }
            return da;

        }


        public void deleteTicket(string transId)
        {
            try
            {
                string connection = "Data Source=IDRAK-PC ;Initial Catalog=NibirProject;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connection);
                SqlCommand cd;



                cnn.Open();

                string sql1 = "delete from dashboard where transId='" + transId + "'";


                cd = new SqlCommand(sql1, cnn);
                int rows = -1;
                rows = cd.ExecuteNonQuery();


                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e.Message);
            }
        }


    }
}
