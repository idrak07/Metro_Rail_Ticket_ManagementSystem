using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_Rail_Ticket_Management.Repository
{
    class AdminAddScheduleRepo
    {

        public void addTrain(string classValue, string seat, string fare, string avaSeat, string trainName, string dateV, string timeval, string dep, string des)
        {
            try
            {
                string connection = "Data Source=IDRAK-PC ;Initial Catalog=NibirProject;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connection);
                SqlCommand cd;



                cnn.Open();

                string sql1 = "insert into tclasses values('c1','c2','"+classValue+"', "+seat+", "+fare+", "+avaSeat+", '"+trainName+"','"+dateV+"' , '"+timeval+"', '"+dep+"', '"+des+"')";


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
