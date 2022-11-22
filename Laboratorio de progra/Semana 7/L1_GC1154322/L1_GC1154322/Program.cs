// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mi segundo programa");


Console.WriteLine("Ingrese su nombre");
string sNombre = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
int sEdad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese su carrera");
string sCarrera = Console.ReadLine();
Console.WriteLine("Ingrese su carné universitario");
int sCarne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nombre: " + sNombre);
Console.WriteLine("Edad: " + sEdad);
Console.WriteLine("Carrera: " + sCarrera);
Console.WriteLine("Carné: " + sCarne);

Console.WriteLine("Soy " + sNombre + ", tengo " + sEdad + " años y estudio en la carrera de " + sCarrera + ". Mi número de carné es: " + sCarne);
Console.ReadKey();
