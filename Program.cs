using System;

namespace Smarthome
{
    class Program
    {
        static void Main(string[] args)
        {
            var hub = new SmartHomeFacade();

            var lamp = new Lamp();

            hub.AddDevice(lamp);

            hub.TurnOnLamp();

            hub.Replay();

            Console.WriteLine("\nTryck valfri tangent...");
            Console.ReadKey();
        }
    }
}
