using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class TurnOnCommand : ICommand
    {
        private IDevice _device;

        public TurnOnCommand(IDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.TurnOn();
        }
    }
}