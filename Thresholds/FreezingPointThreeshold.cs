using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousThermometre.Thresholds
{
    public class FreezingPointThreeshold : IThreshold
    {
        public readonly float FreezingPointTemp;

        public FreezingPointThreeshold(float freezingPointTemp)
        {
            this.FreezingPointTemp = freezingPointTemp;
        }

        public string GetMessages(float temp)
        {
            string message = string.Empty;
            if (temp == FreezingPointTemp)
            {
                message = "Freezing";
            }
            return message;
        }
    }
}
