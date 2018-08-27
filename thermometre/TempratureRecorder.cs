using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousThermometre.Observer.thermometre
{
    public interface  TempratureRecorder
    {
        void NewTemperature(float temp);
    }
}
