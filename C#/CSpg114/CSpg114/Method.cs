using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg114
{
    class CSpg114Class
    {
        public static int MethodOne(int integerOne)
        {
            int timesTwo = (integerOne * 2);
            return timesTwo;
        }

        public static decimal MethodOne(decimal decimalOne)
        {
            decimal dividedBy = (decimalOne / 2);
            Convert.ToInt32(dividedBy);
            return dividedBy;
        }

        public static string MethodOne(string stringOne)
        {
            int plusTen = (10 + Convert.ToInt32(stringOne));
            string plusTenConvertedToString = Convert.ToString(plusTen);
            return plusTenConvertedToString;
        }
    }
}
