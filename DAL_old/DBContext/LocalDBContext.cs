using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    //[DbConfigurationType(typeof(MySqlConfiguration))]
    public class LocalDBContext : DbContext
    {
        public LocalDBContext() : base("name=MysqlConnection") { }

        public DbSet<RedisMQLog> RedisMQLog { get; set; }
    }
}
