using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleStore
{
    public static class CalTotal
    {
        internal static double TAX_RATE { get; private set; } = 0.0886;
        public static void Total(ref double total)
        {
            total += total * TAX_RATE;
        }
    }
}
