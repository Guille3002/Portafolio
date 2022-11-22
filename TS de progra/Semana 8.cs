// See https://aka.ms/new-console-template for more information
Console.WriteLine("Actividad 3");

double F;
double C;

Console.WriteLine("Ingrese una temperatura en grados Fahrenheit: ");
F = Convert.ToDouble(Console.ReadLine());
C = 0.55 * (F - 32);
Console.WriteLine("El valor de la temperatura en Celsius es: " + Math.Round(C));


Console.ReadKey();
