using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HangfireClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage(@"Data Source=DESKTOP-FZN\SQLEXPRESS;User Id=sa;Password=123456;Database=DataSample;Pooling=true;Max Pool Size=5000;Min Pool Size=0;");

            //支持基于队列的任务处理：任务执行不是同步的，而是放到一个持久化队列中，以便马上把请求控制权返回给调用者。  
            //var jobId = BackgroundJob.Enqueue(() => Console.WriteLine("{0}===》这是队列任务!", DateTime.Now.ToString("HH:mm:ss")));

            //延迟任务执行：不是马上调用方法，而是设定一个未来时间点再来执行。  
            //BackgroundJob.Schedule(() => Console.WriteLine("{0}===》这是延时任务!", DateTime.Now.ToString("HH:mm:ss")), TimeSpan.FromSeconds(5));

            //循环任务执行：一行代码添加重复执行的任务，其内置了常见的时间循环模式，也可基于CRON表达式来设定复杂的模式。  
            RecurringJob.AddOrUpdate("ff",() => Console.WriteLine("{0}===》这是每分钟执行的任务!", DateTime.Now.ToString("HH:mm:ss")), Cron.Minutely); //注意最小单位是分钟  

            //延续性任务执行：类似于.NET中的Task,可以在第一个任务执行完之后紧接着再次执行另外的任务  
            //BackgroundJob.ContinueWith(jobId, () => Console.WriteLine("{0}===》这是延续性任务!", DateTime.Now.ToString("HH:mm:ss")));
            var server = new BackgroundJobServer();

            //Action _action = Job2;

            //Expression<Action> _expressionAction = () => _action();

            //var jobId = BackgroundJob.Enqueue(new Expression<Action>);

            try
            {
                //var jobId = BackgroundJob.Enqueue(() => Job2());
                //RecurringJob.AddOrUpdate("rr",() => Console.WriteLine("{0}===》这是每分钟执行的任务!", DateTime.Now.ToString("HH:mm:ss")), Cron.Minutely); //注意最小单位是分钟  
            }
            catch (Exception ee)
            {
                throw ee;
            }

            Console.ReadKey();
        }

        public static void  Job2() {
            TestBLL _TestBLL = new TestBLL();
            _TestBLL.Add(new TestClass
            {
                Id = 1,
                Title = "测试",
                Content = "测试服务",
                CDate = DateTime.Now
            });
        }

        public static Task Job()
        {
            return Task.Run(() =>
            {
                TestBLL _TestBLL = new TestBLL();
                _TestBLL.Add(new TestClass
                {
                    Id = 1,
                    Title = "测试",
                    Content = "测试服务",
                    CDate = DateTime.Now
                });
            });
        }
    }
}
