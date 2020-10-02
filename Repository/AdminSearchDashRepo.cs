using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_Rail_Ticket_Management.Repository
{
    class AdminSearchDashRepo
    {
        public SqlDataAdapter getSearchDash(string trainname, string date, string time)
        {
            SqlDataAdapter da;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=IDRAK-PC;Initial Catalog=NibirProject;Integrated Security=True");//connection name

                con.Open();

                string sql = "SELECT * from tclasses where trainname='" + trainname + "' and date='" + date + "' and time='" + time + "'";

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

        public void deleteSchedule(int id)
        {
            try
            {
                string connection = "Data Source=IDRAK-PC ;Initial Catalog=NibirProject;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connection);
                SqlCommand cd;



                cnn.Open();

                string sql1 = "delete from tclasses where id=" + id + "";


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
