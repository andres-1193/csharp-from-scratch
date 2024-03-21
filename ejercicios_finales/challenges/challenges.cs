

namespace scharp.basic
{

    //Descripción: Solicita al usuario un número y eleva este número al cuadrado solo si es positivo.
    public class Challenge1
    {
        public void Run()
        {
            double numero;
            bool esNumeroValido = false;

            do
            {
                Console.WriteLine("Por favor, ingresa un número:");
                string input = Console.ReadLine();

                // Intenta convertir el input del usuario a un número
                if (double.TryParse(input, out numero))
                {
                    esNumeroValido = true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            } while (!esNumeroValido);

            // Calcula y muestra el cuadrado del número
            double resultado = Math.Pow(numero, 2);
            Console.WriteLine($"El cuadrado de {numero} es: {resultado}");
        }

    }// FIN Challenge1



    //Descripción: Solicita al usuario dos números. Si el primero es mayor, devuelva 
    //su doble, de lo contrario devuelva el triple del segundo. 
    public class Challenge2
    {
        public void Run()
        {

            double resultado;
            Console.WriteLine("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                resultado = num1 * 2;
            }
            else
            {
                resultado = num2 * 3;
            }

            Console.WriteLine($"El resultado es: {resultado}");

        }
    }// FIN Challenge2


    //Descripción: Pide al usuario un número. Si es positivo, devuelve su raíz 
    //cuadrada, de lo contrario, devuelve su cuadrado. 
    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            double numero = LeerNumero();
            double resultado = ObtenerResultado(numero);
            Console.WriteLine($"El resultado es: {resultado}");


            static double LeerNumero()
            {
                double numero;
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, ingrese un número válido:");
                }
                return numero;
            }

            static double ObtenerResultado(double num)
            {
                if (num >= 0)
                {
                    return Math.Sqrt(num); // Devuelve la raíz cuadrada si el número es positivo
                }
                else
                {
                    return Math.Pow(num, 2); // Devuelve el cuadrado si el número es negativo
                }
            }//fin metodo
        }// FIN Challenge3
    }
        

//Descripción: Pide al usuario el radio de un círculo y calcula su perímetro.
 public class Challenge4
        {
            public void Run()
            {
                Console.WriteLine("Ingrese el radio del círculo:");
                double radio = LeerNumeroPositivo();
                double perimetro = CalcularPerimetroCirculo(radio);
                Console.WriteLine($"El perímetro del círculo es: {perimetro}");
            }

            static double LeerNumeroPositivo()
            {
                double numero;
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out numero) && numero > 0)
                    {
                        return numero;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un número positivo válido:");
                    }
                }
            }

            static double CalcularPerimetroCirculo(double radio)
            {
                return 2 * Math.PI * radio;
            }

        }//fin challenge 4




        //Solicita al usuario un número entre 1 y 7 y muestra el día de la 
        //semana correspondiente, pero solo considerando los días laborables. 
        public class Challenge5
        {
            public void Run()
            {

                Console.WriteLine("Ingrese un número entre 1 y 7:");
                int numero = LeerNumeroEntre1y7();

                string diaSemana = ObtenerDiaSemana(numero);

                Console.WriteLine($"El día de la semana correspondiente al número {numero} es: {diaSemana}");

                static int LeerNumeroEntre1y7()
                {
                    int numero;
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out numero) && numero >= 1 && numero <= 7)
                        {
                            return numero;
                        }
                        else
                        {
                            Console.WriteLine("Por favor, ingrese un número entre 1 y 7:");
                        }
                    }
                }

                static string ObtenerDiaSemana(int numero)
                {
                    switch (numero)
                    {
                        case 1:
                            return "Lunes";
                        case 2:
                            return "Martes";
                        case 3:
                            return "Miércoles";
                        case 4:
                            return "Jueves";
                        case 5:
                            return "Viernes";
                        default:
                            return "No es un día laborable";
                    }
                }

            }

        }// fin  Challenge5


        //Solicita al usuario su salario anual y, si este excede los 12000, 
        //muestra el impuesto a pagar que es el 15% del excedente. 
        public class Challenge6
        {
            public void Run()
            {

                Console.Write("Por favor, ingresa tu salario: ");
                double salario = double.Parse(Console.ReadLine());

                if (salario > 1000)
                {
                    double excedente = salario - 1000;
                    double impuesto = excedente * 0.10;
                    Console.WriteLine("El impuesto a pagar es: {0}", impuesto);
                }
            }
        } //fin challenge6
 

 //Solicita dos números y muestra el residuo de la división del primero entre el segundo. 
        public class Challenge7
        {
            public void Run()
            {
                try
                {
                    Console.WriteLine("numero a dividir");
                    double num = double.Parse(Console.ReadLine());
                    Console.WriteLine("numero divisor");
                    double div = double.Parse(Console.ReadLine());
                    if (div == 0)
                    {
                        throw new DivideByZeroException();
                    }


                    Console.WriteLine($"el resultado  es:{num / div} ");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"no se puede dividir por cero ");
                }
                catch (Exception)
                {
                    Console.WriteLine($"Error ");

                }
            }
        }// challenge7



        //Calcula y muestra la suma de los números pares entre 1 y 50. 

        public class Challenge8
        {
            public void Run()
            {

                int sumaPares = CalcularSumaPares();
                Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {sumaPares}");

                static int CalcularSumaPares()
                {
                    int suma = 0;
                    for (int i = 2; i <= 50; i += 2)
                    {
                        suma += i;
                    }
                    return suma;
                }
            }
        }  // challenge8

        
 //Solicita al usuario los valores para dos fracciones y muestra la diferencia entre esas fracciones. 
    public class Challenge9
        {
            public void Run()
            {
                Console.WriteLine("Ingrese el numerador de la primera fracción:");
                int numerador1 = LeerNumero();

                Console.WriteLine("Ingrese el denominador de la primera fracción:");
                int denominador1 = LeerDenominador();

                Console.WriteLine("Ingrese el numerador de la segunda fracción:");
                int numerador2 = LeerNumero();

                Console.WriteLine("Ingrese el denominador de la segunda fracción:");
                int denominador2 = LeerDenominador();

                Console.WriteLine($"La diferencia entre las fracciones {numerador1}/{denominador1} y {numerador2}/{denominador2} es: {CalcularDiferencia(numerador1, denominador1, numerador2, denominador2)}");


                static int LeerNumero()
                {
                    int numero;
                    while (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine("Por favor, ingrese un número válido:");
                    }
                    return numero;
                }

                static int LeerDenominador()
                {
                    int denominador;
                    while (true)
                    {
                        denominador = LeerNumero();
                        if (denominador != 0)
                        {
                            return denominador;
                        }
                        else
                        {
                            Console.WriteLine("El denominador no puede ser cero. Por favor, ingrese un denominador diferente:");
                        }
                    }
                }

                static double CalcularDiferencia(int numerador1, int denominador1, int numerador2, int denominador2)
                {
                    double fraccion1 = (double)numerador1 / denominador1;
                    double fraccion2 = (double)numerador2 / denominador2;
                    return fraccion1 - fraccion2;
                }
            }

        } // challenge9

        

    //Pide una palabra al usuario y muestra la longitud de esa palabra.
    public class Challenge10
    {
        public void Run()
        {

            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            int longitud = CalcularLongitudPalabra(palabra);

            Console.WriteLine($"La longitud de la palabra \"{palabra}\" es: {longitud}");


            static int CalcularLongitudPalabra(string palabra)
            {
                return palabra.Length;
            }

        }
    }// challenge10


    // Pide al usuario cuatro números y muestra el promedio. 
    public class Challenge11
    {
        public void Run()
        {

            Console.WriteLine("Ingrese el primer número:");
            double numero1 = LeerNumero();

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = LeerNumero();

            Console.WriteLine("Ingrese el tercer número:");
            double numero3 = LeerNumero();

            Console.WriteLine("Ingrese el cuarto número:");
            double numero4 = LeerNumero();

            double promedio = CalcularPromedio(numero1, numero2, numero3, numero4);


            Console.WriteLine($"El promedio de los números ingresados es: {promedio}");


            static double LeerNumero()
            {
                double numero;
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, ingrese un número válido:");
                }
                return numero;
            }

            static double CalcularPromedio(double num1, double num2, double num3, double num4)
            {
                return (num1 + num2 + num3 + num4) / 4;
            }
        }
    }// Challenge11


    //   Pide al usuario cinco números y muestra el más pequeño. 
    public class Challenge12
    {
        public void Run()
        {

            Console.WriteLine("Ingrese cinco números:");
            double[] numeros = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = LeerNumero();
            }

            double menorNumero = EncontrarMenorNumero(numeros);

            Console.WriteLine($"El número más pequeño es: {menorNumero}");


            static double LeerNumero()
            {
                double numero;
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, ingrese un número válido:");
                }
                return numero;
            }

            static double EncontrarMenorNumero(double[] numeros)
            {
                double menor = numeros[0];
                for (int i = 1; i < numeros.Length; i++)
                {
                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                    }
                }
                return menor;
            }
        }

    }//fin Challenge12


    //Pide una palabra al usuario y devuelve el número de vocales en  esa palabra.

    public class Challenge13
    {
        public void Run()
        {

            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            int numVocales = ContarVocales(palabra);

            Console.WriteLine($"El número de vocales en la palabra \"{palabra}\" es: {numVocales}");


            static int ContarVocales(string palabra)
            {
                int contador = 0;
                foreach (char letra in palabra)
                {
                    if (EsVocal(letra))
                    {
                        contador++;
                    }
                }
                return contador;
            }

            static bool EsVocal(char letra)
            {
                // Convertimos la letra a minúscula para hacer las comparaciones
                char letraMinusc = char.ToLower(letra);

                // Verificamos si la letra es una vocal
                return letraMinusc == 'a' || letraMinusc == 'e' || letraMinusc == 'i' || letraMinusc == 'o' || letraMinusc == 'u';
            }
        }

    }   // Challenge13



    // Pide un número al usuario y devuelve el factorial de ese número. 
    public class Challenge14
    {
        public void Run()
        {

            Console.WriteLine("Ingrese un número para calcular su factorial:");
            int numero = LeerNumeroEntero();

            long factorial = CalcularFactorial(numero);

            Console.WriteLine($"El factorial de {numero} es: {factorial}");

            static int LeerNumeroEntero()
            {
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
                {
                    Console.WriteLine("Por favor, ingrese un número entero no negativo:");
                }
                return numero;
            }

            static long CalcularFactorial(int numero)
            {
                if (numero == 0)
                {
                    return 1;
                }

                long resultado = 1;
                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;
                }
                return resultado;
            }

        }
    } // fin Challenge14



    //Pide un número al usuario y verifica si está en el rango de 10 a 20 (ambos incluidos). 
    public class Challenge15
    {
        public void Run()
        {


            Console.WriteLine("Ingrese un número para verificar si está en el rango de 10 a 20:");
            int numero = LeerNumeroEntero();

            if (EstaEnRango(numero, 10, 20))
            {
                Console.WriteLine($"El número {numero} está en el rango de 10 a 20.");
            }
            else
            {
                Console.WriteLine($"El número {numero} NO está en el rango de 10 a 20.");
            }


            static int LeerNumeroEntero()
            {
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido:");
                }
                return numero;
            }

            static bool EstaEnRango(int numero, int limiteInferior, int limiteSuperior)
            {
                return numero >= limiteInferior && numero <= limiteSuperior;
            }
        }

    }//fin Challenge15
    
}// fin namespace