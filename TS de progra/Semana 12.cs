// See https://aka.ms/new-console-template for more information


string[] vow = {"a", "e", "i", "o", "u"};
int[] num = { 1, 2, 3, 4, 5 };


Console.Write("Combinaciones posibles: ");

for (int i = 0; i < 5; i++)
{
    
    for (int j = 0; j < 5; j++)
    {
        Console.Write(vow[i] + num[j] + " ");
    }
}
Console.ReadKey();












