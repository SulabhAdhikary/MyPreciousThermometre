using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPreciousThermometre.VmDomain;

namespace MyPreciousThermometre.Displayer
{
    public class DegreeDisplay : IDisplay
    {
        public void  PrintMessage(float  temp)
        {
            Console.Write($"The temprature in degree is {temp}");
          
        }
    }
}
