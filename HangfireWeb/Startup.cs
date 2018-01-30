using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.MySql;

[assembly: OwinStartup(typeof(HangfireWeb.Startup))]

namespace HangfireWeb
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //GlobalConfiguration.Configuration
            //    .UseSqlServerStorage(@"Data Source=DESKTOP-FZN\SQLEXPRESS;User Id=sa;Password=123456;Database=DataSample;Pooling=true;Max Pool Size=5000;Min Pool Size=0;");

            GlobalConfiguration.Configuration
                .UseStorage(new MySqlStorage(@"Data Source=127.0.0.1; port=3306; Initial Catalog=hangfire_fat; uid=root; pwd=sdmp;Allow Zero Datetime=True;charset=utf8;"));

            app.UseHangfireDashboard();
        }
    }
}
