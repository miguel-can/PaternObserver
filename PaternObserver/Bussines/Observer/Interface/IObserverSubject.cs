using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternObserver.Bussines.Observer.Interface
{
    public interface IObserverSubject
    {
        void AddOpcion(IObserverOpciones _Observer);
        void Notify();
    }
}
