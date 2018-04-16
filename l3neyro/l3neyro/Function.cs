using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3neyro
{
    class Function
    {
        public double X1 { get; set; }
        public double X2 { get; set; }

        public double GetResult()
        {
            return (1 - X1 * X1) + 2 * Math.Pow((1 - X2), 2);
        }
    }
}
