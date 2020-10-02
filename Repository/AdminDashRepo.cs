using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_Rail_Ticket_Management.Repository
{
    class AdminDashRepo
    {
        public SqlDataAdapter getTrainName()
        {
            SqlDataAdapter da;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=IDRAK-PC;Initial Catalog=NibirProject;Integrated Security=True");//connection name

                con.Open();

                string sql = "Select * from trains";

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
