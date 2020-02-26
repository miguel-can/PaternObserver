using PaternObserver.Bussines.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternObserver.Bussines
{
    public class PruebasUnitarias : IObserverOpciones
    {
        public void Procesar()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
