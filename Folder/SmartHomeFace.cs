using System;
using System.Collections.Generic;

namespace Smarthome
{
    public class SmartHomeFacade
    {
        private CommandInvoker _invoker = new CommandInvoker();
        private List<IDevice> _devices = new List<IDevice>();

        public void AddDevice(IDevice device) => _devices.Add(device);

        public void RunCommand(ICommand cmd) => _invoker.ExecuteCommand(cmd);

        public void MorningRoutine()
        {
            Console.WriteLine("\n--- Aktiverar Morning Routine ---");
            foreach (var device in _devices)
            {
                _invoker.ExecuteCommand(new TurnOnCommand(device));
            }
        }

        public void Replay() => _invoker.ReplayLast5();
    }
}