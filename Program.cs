using MyPreciousThermometre.Displayer;
using MyPreciousThermometre.Observer;
using MyPreciousThermometre.Observer.thermometre;
using MyPreciousThermometre.Thresholds;
using System;

namespace MyPreciousThermometre
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SpecialDeviceTempratureRecorder objSpecialDeviceTempratureRecorder = new SpecialDeviceTempratureRecorder();
            objSpecialDeviceTempratureRecorder.StartThermometreReading().ConfigureAwait(false);
             var objTempratureMesaureMent =  new TempratureMeasurer(objSpecialDeviceTempratureRecorder);
            objTempratureMesaureMent.AddDisplayer(new DegreeDisplay());
            objTempratureMesaureMent.AddDisplayer(new Fahrenheightdisplay());

            objTempratureMesaureMent.AddThressHolds(new BoilingPointThreeshold(100));
            objTempratureMesaureMent.AddThressHolds(new FreezingPointThreeshold(0));
            Console.ReadKey();
        }
    }
}