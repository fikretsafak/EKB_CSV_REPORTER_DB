using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Veritabani
{
    public class CRUD
    {
        static DataTable dt;
        public static DataTable Listele(string sql)
        {
            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, Baglan.connection);
            adtr.Fill(dt);
            return dt;
        }
        public static bool ESG(string sql)
        {
            int dogrula = 0;
            SQLiteCommand command = new SQLiteCommand(sql, Baglan.connection);
            Baglan.connection.Open();
            dogrula = command.ExecuteNonQuery();

            Baglan.connection.Close();
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
