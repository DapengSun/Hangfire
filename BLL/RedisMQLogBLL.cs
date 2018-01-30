using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RedisMQLogBLL
    {
        RedisMQLogDAL _redisMQLogDal = new RedisMQLogDAL();

        public bool Add(RedisMQLog _redisMQLog)
        {
            return _redisMQLogDal.Add(_redisMQLog);
        }

        public bool Update(RedisMQLog _redisMQLog)
        {
            return _redisMQLogDal.Update(_redisMQLog);
        }
    }
}
