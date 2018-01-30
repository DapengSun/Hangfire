using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireClient
{
    public class TestDAL
    {
        public bool Add(TestClass _testClass) {
            try
            {
                using (var context = new LocalDBContext())
                {
                    context.TestClass.Add(_testClass);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
    }
}
