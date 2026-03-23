using System;

namespace Smarthome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiera systemet via Facade
            var hub = new SmartHomeFacade();

            // Skapa enheter
            var livingRoomLamp = new Lamp();
            var kitchenThermostat = new ThermoStat();
            var frontDoor = new DoorLock();

            // Registrera enheter i hubben
            hub.AddDevice(livingRoomLamp);
            hub.AddDevice(kitchenThermostat);
            hub.AddDevice(frontDoor);

            // 1. Kör en automatiserad rutin
            hub.MorningRoutine();

            // 2. Kör manuella kommandon
            hub.RunCommand(new SetTemperatureCommand(kitchenThermostat, 22));
            hub.RunCommand(new TurnOnCommand(frontDoor)); // Låser dörren

            // 3. Spela upp historik
            hub.Replay();

            Console.WriteLine("Systemet körs. Tryck på valfri tangent för att avsluta...");
            Console.ReadKey();
        }
    }
}
