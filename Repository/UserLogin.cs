using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Metro_Rail_Ticket_Management.Repository
{
    class UserLogin
    {
        private const string V = "SELECT * from users where userid='";

        public int getLoginInfo(string userid, string password)
        {
            SqlConnection con = new SqlConnection("Data Source=IDRAK-PC;Initial Catalog=NibirProject;Integrated Security=True");//connection name
            //Data Source=[ Server Name ];Initial Catalog=[ Database Name ];Integrated Security=True
            int flag = 0;
            try
            {

                con.Open();

                string sql = V + userid + "' and password='" + password + "'";//SELECT * FROM USER WHERE USERID = 'ABJH' AND PASSWORD='HBSGJH'
                //string mysqlString = "SELECT * FROM USER WHERE USERID = '"+ userid +"' AND PASSWORD='"+ password +"'";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.CommandType = CommandType.Text;

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        flag = sqlDataReader.GetInt32(3);
                    }
                }
                else
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                con.Close();
            }
            return flag;
        }


    }
}
