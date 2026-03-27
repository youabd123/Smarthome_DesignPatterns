using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Smarthome
{
    public class Lamp
    {
        private List<IObserver> _observers = new List<IObserver>();

        public bool IsOn { get; private set; }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void TurnOn()
        {
            IsOn = true;
            Notify("Lampan tändes");
        }

        public void TurnOff()
        {
            IsOn = false;
            Notify("Lampan släcktes");
        }

        private void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public string GetStatus()
        {
            return IsOn ? "Tänd" : "Släckt";
        }
    }
}