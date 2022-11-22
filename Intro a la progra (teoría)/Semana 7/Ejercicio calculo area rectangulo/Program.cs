// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cáculo de aréa y perímetro de un rectángulo!");
int h, b;
Console.WriteLine("Ingrese un valor para la base del rectángulo");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un valor para la altura del rectángulo");
h = Convert.ToInt32(Console.ReadLine());

//Cálculo del area
int area;
area = b * h;
Console.WriteLine("El valor del área es:" + area);
//Perimetro
int lado;
Console.WriteLine("Ingrese un valor para los lados  del rectángulo");
lado = Convert.ToInt32(Console.ReadLine());
//Calculo del perímetro
int perimetro;
perimetro = lado + lado + lado + lado;
Console.WriteLine("El peeimetro del rectangulo es: " + perimetro);

Console.ReadKey();

