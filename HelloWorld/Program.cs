

namespace HelloWorld
{

    class Program
    {

        static void Main()
        {
            /*Data 
            int myNum = 5;
            double myDoubleNum =5.990;
            char myletter = 'D';
            bool mybool = true;
            string mytext= "hello";
            var Name = "Jhon Smith ";
            int? mynewvar =null;*/


            /*Console.WriteLine($"Hello World {Name}");
            Console.WriteLine($"Thanks for commit {Name}");
            Console.WriteLine($"Thanks for commit {mynewvar}");*/
   
            DateOnly dateconverter =new DateOnly();
            string nameInput;
            string  birthdayInput;
            Console.WriteLine("Hola bienvenido al calculador de años");
            Console.WriteLine("Escribe tu Nombre");
            nameInput=Console.ReadLine();
            Console.WriteLine($"Es un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu Fecha de nacimiento en formato dd/mm/yy");
            birthdayInput=Console.ReadLine();
           bool IsDateValid=DateOnly.TryParse(birthdayInput,out dateconverter);
           if (IsDateValid==false)   Console.WriteLine($"Usted ingreso la fecha incorrecta {birthdayInput}");
           var person =new Person{
             Name=nameInput,
             birthday=dateconverter,
             age=DateTime.Now.Year-dateconverter.Year

           };
             Console.WriteLine($"Tu nombre : {person.Name}");
             Console.WriteLine($"Tu fecha de Nacimiento : {person.birthday}");
             Console.WriteLine($"Tu edad es : {person.age}");
           Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int age { get; set; }
        public DateOnly birthday { get; set; }
    }

}
