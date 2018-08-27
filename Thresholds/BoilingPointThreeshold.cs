using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousThermometre.Thresholds
{
    public class BoilingPointThreeshold : IThreshold
    {
        public readonly float BoilingThresshold;

         public BoilingPointThreeshold(float boilingPointThreeshold)
        {
            this.BoilingThresshold = boilingPointThreeshold;
        }

        public string GetMessages(float temp)
        {
            string message = string.Empty;
            if (temp == BoilingThresshold)
            {
                message = "Boiling";
            }
            return message;
        }
    }
}
