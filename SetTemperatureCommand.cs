using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class SetTemperatureCommand : ICommand
    {
        private ThermoStat _thermo;
        private int _newTemp;

        public SetTemperatureCommand(ThermoStat thermo, int temp)
        {
            _thermo = thermo;
            _newTemp = temp;
        }

        public void Execute()
        {
            _thermo.SetTemperature(_newTemp);
        }
    }
}