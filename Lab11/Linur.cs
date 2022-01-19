using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    struct Linur
    {
        double k;
        double b;
        public Linur(double k, double b)
        { this.k = k;
            this.b = b; }
        public string Root ()
        {double x ;
            if (k < 0 || k > 0)
            {
                x = -b / k;
                return $"х равен - {x}"; 
            }
            else
                return "х-любое число";
        }
    }     
}


