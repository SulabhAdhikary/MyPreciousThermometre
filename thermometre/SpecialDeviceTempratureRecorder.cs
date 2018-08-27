using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousThermometre.Observer.thermometre
{
    public class SpecialDeviceTempratureRecorder : TempratureRecorder
    {
        private static List<TempratureMeasurerActions> tempratureChangedMeasurerObserver = new List<TempratureMeasurerActions>();
        private static  SpecialDeviceTempratureRecorder instance;
        public  async Task StartThermometreReading()
        {
            Thermometer objThermometer = new Thermometer();
            objThermometer.TempratureChanged += NewTemperature;
             await objThermometer.StartTempratureRecording();
        }

        public static SpecialDeviceTempratureRecorder GetInstance()
        {
            if(instance!= null)
            {
                return instance;
            }
            instance = new SpecialDeviceTempratureRecorder();
            return instance;
        }

        public void AddTempratureMeasurer(TempratureMeasurerActions prmTempratureMeasurer)
        {
            tempratureChangedMeasurerObserver.Add(prmTempratureMeasurer);
        }

        public void NewTemperature(float temprature)
        {
            tempratureChangedMeasurerObserver.ForEach(t => t.TempratureChnaged(temprature));
        }
    }
}
