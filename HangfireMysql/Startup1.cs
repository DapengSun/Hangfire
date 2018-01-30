using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.MySql;

[assembly: OwinStartup(typeof(HangfireMysql.Startup1))]

namespace HangfireMysql
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseStorage(new MySqlStorage("server=127.0.0.1;uid=root;pwd=sdmp;database=spiderdb;Allow User Variables=True;"));
            app.UseHangfireDashboard();
        }
    }
}
