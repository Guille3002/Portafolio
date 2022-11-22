// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio carita feliz");

string word1;
int i;
for (i = 0; i < 9; i++)
{

    Console.WriteLine("Escriba una palabra para validad si es o no molesta");
    word1 = Console.ReadLine().ToString();


    string auxiliar = word1.ToUpper();

    if (word1 == auxiliar)
    {
        Console.WriteLine("Palabra molesta");
    }
    else
    {
        if (word1.Contains("!!"))
        {
            Console.WriteLine("Palabra molesta");
        }
        else
        {
            if (word1 != auxiliar)
            {
                Console.WriteLine("Palabra no molesta");

            }
        }
    }
}
