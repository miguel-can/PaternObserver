using PaternObserver.Bussines.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternObserver.Bussines
{
    public class SubirCodigo : IObserverOpciones
    {
        public void Procesar()
        {
            Console.WriteLine("Commit de código de la versión 1.1");
        }
    }
}
