using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireClient
{
    public class TestBLL
    {
        private TestDAL _TestDAL = new TestDAL();

        public bool Add(TestClass _testClass) {
            return _TestDAL.Add(_testClass);
        }
    }
}
