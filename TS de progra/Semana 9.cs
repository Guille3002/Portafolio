// See https://aka.ms/new-console-template for more information


int result;
Console.WriteLine("Sistema de calificaciones");
Console.WriteLine("Ingrese una nota");
result = Convert.ToInt32(Console.ReadLine());
if (result >= 90)
{
   Console.WriteLine("Su calificación es: A");
}
else if (result >= 80 && result <90) 
{
    Console.WriteLine("Su calificación es: B");
}
else if(result >= 70 && result <80)
{
    Console.WriteLine("Su calificación es: C");

}
else if (result >= 60 && result < 70)
{
    Console.WriteLine("Su calificación es: D");
}
else if (result >= 50 && result < 60)
{
    Console.WriteLine("Su calificación es: E");
}
else if (result >= 0 && result < 50)
{
    Console.WriteLine("Su calificación es: F");
}



