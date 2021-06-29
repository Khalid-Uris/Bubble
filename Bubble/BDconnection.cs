using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bubble
{
/*    class BDconnection
    {

        public int[] PrintSql_Array()
        {
            int[] medal = new int[11];

            int cont = 0;

            string cs = @"Data Source=DESKTOP-153RETS;Initial Catalog=P2_Data;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Gold from Summer_Olympic_Games_Data where Year=1896";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        medal[cont] = row.Field<int>(0);

                        cont++;
                    }

                    return medal;
                    for(int i=0; i<medal.Length; i++)
                    {
                        Console.WriteLine("{0} ", medal[i]);
                        
                    }
                    con.Close();
                }
            }
        }

    }*/
}
