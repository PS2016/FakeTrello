using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Mock.Mock
{
    public static class MockNumber
    {
        public static int GetNumber()
        {
            var rnd = new Random();
            return rnd.Next();
        }
    }
}
