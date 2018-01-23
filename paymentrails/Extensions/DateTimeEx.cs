using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRails.Extensions
{
    internal static class DateTimeEx
    {
        public static long ToUnixTimeStamp(this DateTime datetime)
        {
            return (long)datetime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}