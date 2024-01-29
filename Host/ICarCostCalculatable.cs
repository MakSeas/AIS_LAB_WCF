using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host
{
    [ServiceContract]
    public interface ICarCostCalculatable
    {
        [OperationContract]
        double GetCarCost(int mark, int year, int engine, int color, int complect);
    }
}
