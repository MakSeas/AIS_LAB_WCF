using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    public class CarCostCalculator:ICarCostCalculatable
    {
        public double GetCarCost(int mark, int year, int engine, int color, int complect)
        {
            return (mark+year*10+engine*2+color+complect*5)*150;
        }
    }
}
