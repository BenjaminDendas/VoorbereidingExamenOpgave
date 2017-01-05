using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado3LagenMonster
{
   public static class ConnectDB
    {
       public static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "(localdb)\\MSSQLLocalDB";
            builder.InitialCatalog = "GameEF.GameContext";
            builder.IntegratedSecurity = true;
            return new SqlConnection(builder.ConnectionString);
        }
    }
}
