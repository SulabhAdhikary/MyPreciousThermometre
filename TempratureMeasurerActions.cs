using MyPreciousThermometre.Observer.thermometre;

namespace MyPreciousThermometre.Observer
{
    public abstract class TempratureMeasurerActions
    {
        protected SpecialDeviceTempratureRecorder recorder;

        public abstract void TempratureChnaged(float temprature);
    }
}