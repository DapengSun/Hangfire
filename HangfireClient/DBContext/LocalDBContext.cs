using HangfireClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class LocalDBContext :DbContext
    {
        public LocalDBContext() : base(@"Data Source=127.0.0.1; port=3306; Initial Catalog=spiderdb; uid=root; pwd=sdmp;Allow Zero Datetime=True;charset=utf8;") { }

        public DbSet<TestClass> TestClass { get; set; }
    }
}
