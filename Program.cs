using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaTerminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor de ingresar la cantidad de estaciones que avanzó el tren:");
            int estacion = Int32.Parse(Console.ReadLine());

             void reporteDePasajeros(int est)
             {
                est = estacion;

                    switch (est)
                    {
                        case 0:

                            Console.WriteLine("En la estación 0 hay 200 pasajeros arriba del tren");

                        break;

                        case 1:

                            Console.WriteLine("En la estación 0 hay 200 pasajeros arriba del tren. \n" +
                                              "En la estación 1 hay 220 pasajeros arriba del tren");
                        break;

                        case 2:

                        Console.WriteLine("En la estación 0 hay 200 pasajeros arriba del tren. \n" +
                                          "En la estación 1 hay 220 pasajeros arriba del tren.  \n" +
                                          "En la estación 2 hay 240 pasajeros arriba del tren ");
                        break;
                        
                        case 3:


                        Console.WriteLine("En la estación 0 hay 200 pasajeros arriba del tren. \n" +
                                          "En la estación 1 hay 220 pasajeros arriba del tren.  \n" +
                                          "En la estación 2 hay 240 pasajeros arriba del tren \n" +
                                          "En la estación 3 hay 260 pasajeros arriba del tren ");

                        break;

                        case 4:

                        Console.WriteLine("En la estación 0 hay 200 pasajeros arriba del tren. \n" +
                                          "En la estación 1 hay 220 pasajeros arriba del tren.  \n" +
                                          "En la estación 2 hay 240 pasajeros arriba del tren \n" +
                                          "En la estación 3 hay 260 pasajeros arriba del tren \n" +
                                          "En la estación 4 hay 280 pasajeros arriba del tren ");

                         break;

                        case 5:

                        Console.WriteLine("En la estación 0 hay 200 pasajeros arriba del tren. \n" +
                                         "En la estación 1 hay 220 pasajeros arriba del tren.  \n" +
                                         "En la estación 2 hay 240 pasajeros arriba del tren \n" +
                                         "En la estación 3 hay 260 pasajeros arriba del tren \n" +
                                         "En la estación 4 hay 280 pasajeros arriba del tren  \n" +
                                         "En la estación 5 hay 320 pasajeros arriba del tren");

                        break;

                        default:
                            Console.WriteLine("Error ! .Ingrese el Nùmero de la estación");
                        break;
                       
                    }
                
             }
                switch (estacion)
                {

                    case 0:

                        reporteDePasajeros(0);

                    break;

                    case 1:

                        reporteDePasajeros(1);

                    break;

                    case 2:

                        reporteDePasajeros(2);

                    break;

                    case 3:

                        reporteDePasajeros(3);

                    break;

                    case 4:

                        reporteDePasajeros(4);

                    break;

                    case 5:

                        reporteDePasajeros(5);

                    break;

                    default:

                        Console.WriteLine("Error ! .Ingrese el Nùmero de la estación");

                    break;
            }
        }
    }
}
