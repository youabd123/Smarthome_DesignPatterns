using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        string GetStatus();
    }
}
