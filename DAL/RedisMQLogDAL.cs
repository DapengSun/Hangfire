using DAL.DBContext;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RedisMQLogDAL
    {

        public bool Add(RedisMQLog _redisMQLog) {
            using (var context = new LocalDBContext()) {
                context.RedisMQLog.Add(_redisMQLog);
                context.SaveChanges();
                return true;
            }
        }

        public bool Update(RedisMQLog _redisMQLog)
        {
            using (var context = new LocalDBContext())
            {
                context.RedisMQLog.Attach(_redisMQLog);
                context.Entry(_redisMQLog).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }
    }
}
