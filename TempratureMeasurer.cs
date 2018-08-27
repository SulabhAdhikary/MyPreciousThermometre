using MyPreciousThermometre.Displayer;
using MyPreciousThermometre.Observer.thermometre;
using MyPreciousThermometre.Thresholds;
using System;
using System.Collections.Generic;

namespace MyPreciousThermometre.Observer
{
    public class TempratureMeasurer : TempratureMeasurerActions
    {
        private List<IThreshold> lstIThreshold = new List<IThreshold>();
        private List<IDisplay> lstDisplayer = new List<IDisplay>();

        public TempratureMeasurer(SpecialDeviceTempratureRecorder tempratureRecorder)
        {
            this.recorder = tempratureRecorder;
            this.recorder.AddTempratureMeasurer(this);
        }

        public void AddThressHolds(IThreshold thresshold)
        {
            lstIThreshold.Add(thresshold);
        }

        public void AddDisplayer(IDisplay displayer)
        {
            lstDisplayer.Add(displayer);
        }

        public override void TempratureChnaged(float temprature)
        {
            lstDisplayer.ForEach(t => t.PrintMessage(temprature));

            lstIThreshold.ForEach(t =>
            {
                var message = t.GetMessages(temprature);
                if (!string.IsNullOrEmpty(message))
                {
                    Console.WriteLine($" and its {message}");
                }
            });
        }
    }
}