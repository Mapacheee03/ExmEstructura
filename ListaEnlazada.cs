using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Linkedlist
{
    class ListaEnlazada
    {
        public Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        public void Agregar(int valor)
        {
            Nodo _nodo = new Nodo(valor);

            if (cabeza == null)
            {
                cabeza = _nodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = _nodo;
            }
        }

        public void Imprimir()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.valor + "\n");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }



}
