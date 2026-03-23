using System;
using System.Collections.Generic;
using System.Linq;

namespace Smarthome
{
    public class CommandInvoker
    {
        private List<ICommand> _history = new List<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Add(command);
        }

        public void ReplayLast5()
        {
            Console.WriteLine("\n--- System Replay: Återställer senaste händelser ---");

            var lastCommands = _history.Skip(Math.Max(0, _history.Count - 5)).ToList();

            foreach (var cmd in lastCommands)
            {
                cmd.Execute();
            }
            Console.WriteLine("--- Replay slutförd ---\n");
        }
    }
}
