using PaternObserver.Bussines.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternObserver.Bussines.Observer
{
    public class Subject : IObserverSubject
    {
        private List<IObserverOpciones> lstObservers = new List<IObserverOpciones>();

        public void AddOpcion(IObserverOpciones _Observer)
        {
            this.lstObservers.Add(_Observer);
        }

        public void Notify()
        {
            foreach (var observer in this.lstObservers)
            {
                observer.Procesar();
            }
        }
    }
}
