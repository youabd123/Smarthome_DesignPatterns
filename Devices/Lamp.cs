using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class Lamp : IDevice
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            // Singleton + Observer-logik:
            Logger.Instance.Log("Lampan har tänds.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Logger.Instance.Log("Lampan har släckts.");
        }

        public string GetStatus() => IsOn ? "Tänd" : "Släckt";
    }
}
