using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class TurnOnCommand : ICommand
    {
        private Lamp _lamp;

        public TurnOnCommand(Lamp lamp)
        {
            _lamp = lamp;
        }

        public void Execute()
        {
            _lamp.TurnOn();
        }
    }
}