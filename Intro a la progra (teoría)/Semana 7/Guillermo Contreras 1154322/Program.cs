// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio en clase");
double r, pi;

pi = 3.14;
r = 0;
Console.WriteLine("Ingrese un valor para el radio con decimales");
r = Convert.ToDouble(Console.ReadLine());

//Cálculo de área
double area;
area = pi * Math.Pow(r, 2);
Console.WriteLine("El valor del area es: " + area.ToString());
Console.ReadKey();
// Cálculo de área y perímetro
