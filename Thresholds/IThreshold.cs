using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousThermometre.Thresholds
{
    public interface IThreshold
    {  
        string GetMessages(float temp);
    }
}
                                    