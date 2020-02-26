using PaternObserver.Bussines.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternObserver.Bussines
{
    public class CorreoNotificacion : IObserverOpciones
    {
        public void Procesar()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
