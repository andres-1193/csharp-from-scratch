/*clases
Console.WriteLine("Hello, World!");
var rect= new Rectangulo();
rect.Base=20;
rect.Altura=40;

  Console.WriteLine($"El area es : {rect.Area()}");
  Console.WriteLine($"el perimetro es : {rect.Perimetro()}");
/* Clases*/

var cuadr= new Cuadrado();
cuadr.Base=20;
cuadr.Altura=40;

  Console.WriteLine($"El area es : {cuadr.Area()}");
  Console.WriteLine($"el perimetro es : {cuadr.Perimetro()}");
   Console.WriteLine($"el lado es : {cuadr.lado}");

class Rectangulo{

public double Base { get; set; }
public double Altura { get; set; }

public double Area() => Base * Altura;

public double Perimetro() =>  2*Base + 2* Altura;

} 

class Cuadrado : Rectangulo{
     public double lado { 
            set {Base=value;Altura=value;}
            get {return Base;}

      }
}

