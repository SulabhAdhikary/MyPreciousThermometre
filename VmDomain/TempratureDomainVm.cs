using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousThermometre.VmDomain
{
    public class TempratureDomainVm
    {
        public  TempratureDomainVm(float temp)
        {
            this.Temp = temp;
        }
        public float Temp { get; set; }
        public string Message { get; set; }
    }
}
