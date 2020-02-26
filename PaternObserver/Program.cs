using PaternObserver.Bussines;
using PaternObserver.Bussines.Observer;
using PaternObserver.Bussines.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            int iOpcion = 0;
            IObserverOpciones Observador = null;
            IObserverSubject svrPublicador = new Subject();

            Console.WriteLine("**** Proceso de Integración *****");
            Console.WriteLine("Seleccione el NÚMERO que corresponde a la opción de la lista siguiente:");
            Console.WriteLine("1: Subir Código");
            Console.WriteLine("2: Agregar Compilador");
            Console.WriteLine("3: Agregar Ejecutor de Pruebas");
            Console.WriteLine("4: Agregar Instalador");
            Console.WriteLine("5: Agregar Notificador");

            int.TryParse(Console.ReadLine(), out iOpcion);

            while (iOpcion != 0)
            {
                switch (iOpcion)
                {
                    case 1:
                        Observador = new SubirCodigo();
                        Console.WriteLine("Se agrega subir código");
                        break;
                    case 2:
                        Observador = new Compilar();
                        Console.WriteLine("Se agrega compilar");
                        break;
                    case 3:
                        Observador = new PruebasUnitarias();
                        Console.WriteLine("Se agrega pruebas unitarias");
                        break;
                    case 4:
                        Observador = new InstalarVersion();
                        Console.WriteLine("Se agrega instalador");
                        break;
                    case 5:
                        Observador = new CorreoNotificacion();
                        Console.WriteLine("Se agrega correo de notificación");
                        break;
                }

                if (Observador != null)
                {
                    svrPublicador.AddOpcion(Observador);
                }
                
                if (iOpcion == 1)
                    svrPublicador.Notify();

                Console.WriteLine("Seleccione el NÚMERO que corresponde a la opción de la lista siguiente:");
                int.TryParse(Console.ReadLine(), out iOpcion);

                Observador = null;
            }

            Console.Write("Presiona cualquier tecla para salir del programa...");
            Console.ReadKey();
        }
    }
}
