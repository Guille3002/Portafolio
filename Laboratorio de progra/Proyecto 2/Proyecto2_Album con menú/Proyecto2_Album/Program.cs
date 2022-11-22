using System;

namespace Proyecto2_Album
{
    class Program
    {
        static Album album;
        static void marcarestampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);
            if (i >= 0)
            {
                album.estampas[i].marcadas();
            }else
            {
                Console.WriteLine("Estampa no encontrada");
            }
        }
        static void mrepetirestampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);
            if (i >= 0)
            {
                album.estampas[i].repetidas();
            }
            else
            {
                Console.WriteLine("Estampa no encontrada");
            }
        }
        static void Main(string[] args)
        {
            album = new Album();
            int opcion;
            string estampaadesear;
        Menu:
            Console.WriteLine("----------Album del mundial  de Qatar 2022----------");
            Console.WriteLine("ingrese el número de la opción que desee:");
            Console.WriteLine("1.Marcar una estampa");
            Console.WriteLine("2. Observar estampas marcadas");
            Console.WriteLine("3. Observar estampas faltantes");
            Console.WriteLine("4. Observar estampas repetidas");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese las siglas del equipo y su número: ");
                    estampaadesear = Console.ReadLine();
                    marcarestampa(estampaadesear);
                    goto Menu;
                case 2:
                    Console.Clear();
                    album.mostrarMarcadas();
                    goto Menu ;
                    
                case 3:
                    Console.Clear();
                    album.mostrarFaltantes();
                    goto Menu;
                    
                case 4:
                    Console.Clear();
                    album.mostrarRepetidas();
                    goto Menu;
                case 5:
                    Console.WriteLine("Adios!");
                    break;
                    
                default:
                    Console.WriteLine("Error, vuelva a intentar");
                    goto Menu;
                    
            }
        }
    }
}
