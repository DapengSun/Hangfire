using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HangfireServer
{
    class Program
    {
        public static void Main(string[] args)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage(@"Data Source=DESKTOP-FZN\SQLEXPRESS;User Id=sa;Password=123456;Database=DataSample;Pooling=true;Max Pool Size=5000;Min Pool Size=0;");

            Console.WriteLine("Hangfire Server started. Press any key to exit...");
            var server = new BackgroundJobServer();

            Console.ReadKey();
        }
    }
}
