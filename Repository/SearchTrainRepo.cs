using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_Rail_Ticket_Management.Repository
{
    class SearchTrainRepo
    {
        public SqlDataAdapter getSearchDash(string dep,string des, string d)
        {
            SqlDataAdapter da;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=IDRAK-PC;Initial Catalog=NibirProject;Integrated Security=True");//connection name

                con.Open();

                string sql = "SELECT * from tclasses where scheduleId=(select scheduleId from schedules where departure='" +dep + "' and destination='" + des+ "' and date='" + d + "')";

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
    }
}
