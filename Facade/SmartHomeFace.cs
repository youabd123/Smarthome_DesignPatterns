using System;

using System;

namespace Smarthome
{
    public class SmartHomeFacade
    {
        private CommandInvoker _invoker = new CommandInvoker();
        private Lamp? _lamp;

        public void AddDevice(Lamp lamp)
        {
            _lamp = lamp;

            _lamp.AddObserver(new Dashboard());
            _lamp.AddObserver(Logger.Instance);
            _lamp.AddObserver(new AuditService());
        }

        public void TurnOnLamp()
        {
            if (_lamp != null)
            {
                _invoker.ExecuteCommand(new TurnOnCommand(_lamp));
            }
        }

        public void TurnOffLamp()
        {
            if (_lamp != null)
            {
                _invoker.ExecuteCommand(new TurnOffCommand(_lamp));
            }
        }

        public void Replay()
        {
            _invoker.ReplayLast5();
        }
    }
}