using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Otomasyon
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MR7H0LP\SQLEXPRESS;Initial Catalog=DBotomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
