using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinalDBPro
{
    public class Helper
    {
        SqlConnection conn; 

        public Helper()
        {
            conn = new SqlConnection("For privacy reasons I deleted it...");

            conn.Open();
        }

        public void Disconnect()
        {
            conn.Close();
        }

        public DataSet GetDataSetByQuery(string strSql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                var ds = new DataSet();
                var adapter = new SqlDataAdapter(cmd);

                adapter.Fill(ds);

                return ds;
            }
            catch
            {
            }
            return null;
        }

        public void ExecuteSqlCommand(string strSql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
        }
    }
}