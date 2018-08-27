using MyPreciousThermometre.VmDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousThermometre.Displayer
{
    public interface IDisplay
    {
        void PrintMessage(float viewModel);
    }
}
