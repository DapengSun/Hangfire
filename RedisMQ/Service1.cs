using BLL;
using Common;
using Hangfire;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace RedisMQ
{
    public partial class Service1 : ServiceBase
    {
        RedisMQLogBLL _redisMQLogBll = new RedisMQLogBLL();
        protected RedisMQLog _redisMQLog { get; set; }

        private BackgroundJobServer _server;

        public Service1()
        {
            InitializeComponent();

            string ConnectionString = System.Configuration.ConfigurationManager.AppSettings["RedisPath"].ToString();
            GlobalConfiguration.Configuration.UseRedisStorage(ConnectionString);
            _server = new BackgroundJobServer();
        }

        protected override void OnStart(string[] args)
        {
            _redisMQLog = new RedisMQLog { Title = "服务启动", Content = "大方工业云数据同步服务：【服务启动】", CDate = ToolMethods.GetNow() };
            WriteLog(_redisMQLog);

            _server.Start();
        }

        protected override void OnStop()
        {
            _redisMQLog = new RedisMQLog { Title = "服务停止", Content = "大方工业云数据同步服务：【服务停止】",CDate = ToolMethods.GetNow() };
            WriteLog(_redisMQLog);

            _server.Dispose();
        }

        #region 记录服务日志
        /// <summary>
        /// 记录服务日志
        /// </summary>
        /// <param name="msg"></param>
        private void WriteLog(RedisMQLog _redisMQLog)
        {
            _redisMQLogBll.Add(_redisMQLog);
        }
        #endregion

        #region Hangfire处理服务
        public void HangfireService() {
            try
            {
                
            }
            catch (Exception ee)
            {
                _redisMQLog = new RedisMQLog { Title = "服务状态异常", Content = "【服务异常】：" + ee.ToString(), CDate = ToolMethods.GetNow() };
                WriteLog(_redisMQLog);
            }
        }
        #endregion
    }
}
