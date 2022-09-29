using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kütüphane
{
    internal class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=kyladev.database.windows.net;Initial Catalog=Kutuphane;Persist Security Info=True;User ID=********;Password=*******");
            baglan.Open();
            return baglan;
        }

        
    }
}
