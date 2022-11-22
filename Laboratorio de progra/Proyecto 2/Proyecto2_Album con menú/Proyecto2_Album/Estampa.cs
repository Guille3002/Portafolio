using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2_Album
{
    class Estampa
    {
        public string categoria;
        public string codigo;
        public int estado; // 0: faltante, 1: marcada, 2: repetida

        public Estampa(string categoria, int numero)
        {
            this.categoria = categoria;
            this.codigo = categoria + numero;
            this.estado = 0;
        }

        public void marcadas()
        {
            this.estado = 1;
        }

        public void repetidas()
        {
            this.estado = 2;
        }

        public void faltantes()
        {
            this.estado = 0;
        }

        public bool esMarcada()
        {
            return this.estado > 0;
        }

        public bool esRepetida()
        {
            return this.estado == 2;
        }

        public bool esFaltante()
        {
            return this.estado == 0;
        }
    }
}
