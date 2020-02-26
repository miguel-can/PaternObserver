using PaternObserver.Bussines.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternObserver.Bussines
{
    public class InstalarVersion : IObserverOpciones
    {
        public void Procesar()
        {
            Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}
