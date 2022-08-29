using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Database
{
    public class CRUD
    {
        static DataTable dt;
        public static DataTable Listele(string sql)
        {
            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, baglan.connection);
            adtr.Fill(dt);
            return dt;
        }
        public static bool ESG(string sql)
        {
            int dogrula = 0;
            SQLiteCommand command = new SQLiteCommand(sql,baglan.connection);
            baglan.connection.Open();
            dogrula = command.ExecuteNonQuery();

            baglan.connection.Close();
            if (dogrula == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }


    }
}
