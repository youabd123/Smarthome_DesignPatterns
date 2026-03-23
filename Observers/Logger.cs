using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class Logger : IObserver
    {
        // 1. Denna håller i den enda kopian av Logger som finns
        private static Logger _instance;

        // 2. Privat konstruktor gör att ingen kan skriva "new Logger()"
        private Logger() { }

        // 3. Det är DENNA som dina andra klasser letar efter!
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        // Metod för att ta emot meddelanden (från IObserver)
        public void Update(string message)
        {
            Log(message);
        }

        // Metoden som faktiskt skriver ut i konsolen
        public void Log(string message)
        {
            System.Console.WriteLine($"[LOG - {System.DateTime.Now:HH:mm:ss}]: {message}");
        }
    }
}
