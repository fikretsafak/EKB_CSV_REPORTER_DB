using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace Database
{
    public class baglan
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=.\\KARAKURT.db;Versiyon=3");
    }
}
