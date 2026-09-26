using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConnectSqlserver
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("Server=ADMIN\\MSSQLSERVER01;uid = zxcda;pwd=5065848xyz;Database=TestDBForWinform;Trusted_Connection=true;")
        {

        }

        public DbSet<UserTModel> UserTForWinform { get; set; }
    }
}
