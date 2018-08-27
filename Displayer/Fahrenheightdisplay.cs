using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPreciousThermometre.VmDomain;

namespace MyPreciousThermometre.Displayer
{
    public class Fahrenheightdisplay : IDisplay
    {  

        public void PrintMessage(float temp)
        {
            var ftemp = ((9.0 / 5.0) * temp) + 32;
            Console.WriteLine($" and  Fahrenheight is {ftemp}");

        }
    }
}
