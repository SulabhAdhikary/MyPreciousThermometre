using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousThermometre.Observer.thermometre
{
    /// <summary>
    /// Fake Thermometre
    /// </summary>
    public class Thermometer
    {
        public Action<float> TempratureChanged;
        public int TimeIntervalInSeconds { get; set; } = 2;
        public float[] radomTempratures = new float[] {1.5f,1.0f, 0.5f, 0.0f, -0.5f,2f,2,5f,-1f,-1.5f,100f,20f,30f};

        public async Task StartTempratureRecording()
        {
            Console.WriteLine("recording started");
            while (true)
            {
                try
                {
                    Task task = Task.Delay(TimeIntervalInSeconds*1000);
                    await task;
                    Random random = new Random();
                    int randomTempratuer = random.Next(0, radomTempratures.Length);
                    TempratureChanged(radomTempratures[randomTempratuer]);

                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
        }
    }
}
