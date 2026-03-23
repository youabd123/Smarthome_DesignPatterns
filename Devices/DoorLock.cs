using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class DoorLock : IDevice
    {
        public bool IsLocked { get; private set; }

        public void TurnOn() => Lock(); // TurnOn betyder Lås i detta fall
        public void TurnOff() => Unlock();

        public void Lock()
        {
            IsLocked = true;
            Logger.Instance.Log("Dörren är nu LÅST.");
        }

        public void Unlock()
        {
            IsLocked = false;
            Logger.Instance.Log("Dörren är nu UPPLÅST.");
        }

        public string GetStatus() => IsLocked ? "Låst" : "Upplåst";
    }
}
