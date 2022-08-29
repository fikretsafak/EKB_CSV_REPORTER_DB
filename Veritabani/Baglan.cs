using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace Veritabani
{
    public class Baglan
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source= .\\KARAKURT.db ;Versiyon=3");
    }
}
