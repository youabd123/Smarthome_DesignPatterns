using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class ThermoStat : IDevice
    {
        public int Temperature { get; set; } = 20;

        public void TurnOn() => Logger.Instance.Log("Termostaten är aktiv.");
        public void TurnOff() => Logger.Instance.Log("Termostaten är avstängd.");

        public void SetTemperature(int temp)
        {
            Temperature = temp;
            Logger.Instance.Log($"Termostaten ändrad till {Temperature} grader.");
        }

        public string GetStatus() => $"Temperatur: {Temperature}°C";
    }
}
