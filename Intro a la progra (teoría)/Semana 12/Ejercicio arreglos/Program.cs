// See https://aka.ms/new-console-template for more information


int [] _vector;
int contarDatos = 0;
Console.WriteLine("Ingrese cantidad");
contarDatos = int.Parse(Console.ReadLine());
_vector = new int[contarDatos];

for (int i = 0; i < contarDatos; i++)
{
    _vector[i] = int.Parse(Console.ReadLine());
    if (_vector[i] % 2==0) 
    {
        Console.WriteLine("El número" + _vector[i] + "es par");
    }
    else
    {
        Console.WriteLine("El número" + _vector[i] + "es impar");
    }

}
Console.ReadKey();
