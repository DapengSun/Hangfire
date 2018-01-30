using Hangfire;
using Hangfire.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HangfireBLL
    {
        private BackgroundJobServer _server { get; set; }

        public void HangfireService() {
            JobStorage.Current = new SqlServerStorage("connection_string");
            _server = new BackgroundJobServer();
        }
    }
}
