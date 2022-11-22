using System;

namespace Proyecto2_Album
{
    class Program
    {
        static Album album;
        
        static void  marcarEstampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);

            if(i > 0)
            {
                album.estampas[i].marcar();
            }
            else
            {
                Console.WriteLine("Estampa no encontrada");
            }
        }


        static void Main(string[] args)
        {
            
        }
    }
}
