
using System;
using scharp.basic;
namespace scharp.basic
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Bienvenido, {nombre}, elije un ejercicio del menu");
            Menu.MostrarMenu();

            while (true)
            {
                string entrada = Console.ReadLine().ToLower();
                if (entrada == "q" || entrada == "salir")
                {
                    break; // salir del ciclo
                }
                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 16)
                {
                    switch (eleccion)
                    {
                    case 1:
                       var challenge1 = new Challenge1();
                        challenge1.Run();
                        break;
                    case 2:
                         var challenge2 = new Challenge2();
                        challenge2.Run();
                        break;
                    case 3:
                         var challenge3 = new Challenge3();
                        challenge3.Run();
                        break;
                    case 4:
                       var challenge4 = new  Challenge4();
                        challenge4.Run();
                        break;
                   case 5:
                        var challenge5= new Challenge5();
                        challenge5.Run();
                        break;
                    case 6:
                         var challenge6 = new Challenge6();
                        challenge6.Run();
                        break;
                    case 7:
                        var challenge7 = new Challenge7();
                       challenge7.Run();
                        break;
                    case 8:
                         var challenge8 = new Challenge8();
                        challenge8.Run();
                        break;
                    case 9:
                         var challenge9 = new Challenge9();
                        challenge9.Run();
                        break;
                    case 10:
                        var challenge10 = new Challenge10();
                        challenge10.Run();
                        break;
                    case 11:
                       var challenge11 = new Challenge11();
                        challenge11.Run();
                        break;
                    case 12:
                        var challenge12 = new Challenge12();
                        challenge12.Run();
                        break;
                    case 13:
                        var challenge13 = new Challenge13();
                        challenge13.Run();
                        break;
                    case 14:
                         var challenge14 = new Challenge14();
                        challenge14.Run();
                        break;
                    case 15:
                          var challenge15 = new Challenge15();
                        challenge15.Run();
                        break;
                

                      default:
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        Menu.MostrarMenu();
                        break;

                }// fin del switch
                  
                    
                }
                else
                {
                    Console.WriteLine("Opcion no valida, INGRESE UN NUMERO ENTRE 1 Y 15, o 'q' o 'salir' para terminar el programa");
                }

            }//fin ciclo mientras
            Console.WriteLine("Gracias por participar");


        }//fin metodo principal
    }//fin clase
}// fin namespace