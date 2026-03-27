using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class AuditService : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[Audit] {message}");
        }
    }
}
