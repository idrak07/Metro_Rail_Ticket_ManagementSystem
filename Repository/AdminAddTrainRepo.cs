using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_Rail_Ticket_Management.Repository
{
    class AdminAddTrainRepo
    {
        public int maxTrainId()
        {
            SqlConnection con = new SqlConnection("Data Source=IDRAK-PC;Initial Catalog=NibirProject;Integrated Security=True");//connection name
            //Data Source=[ Server Name ];Initial Catalog=[ Database Name ];Integrated Security=True
            int id = 0;
            try
            {

                con.Open();

                string sql = "SELECT MAX(id) from trains";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.CommandType = CommandType.Text;

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        id = sqlDataReader.GetInt32(0);
                    }
                }
                else
                {

                }
            }
            catch (Exception e)
            {
               Console.WriteLine(e.ToString());
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public void addTrain(string id, string trainName)
        {
            try
            {
                string connection = "Data Source=IDRAK-PC ;Initial Catalog=NibirProject;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connection);
                SqlCommand cd;



                cnn.Open();

                string sql1 = "INSERT into trains values ('"+ id +"','"+ trainName +"')";


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
